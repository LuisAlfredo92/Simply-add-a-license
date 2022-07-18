using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel.Design;
using Task = System.Threading.Tasks.Task;
using EnvDTE80;
using System.IO;
using System.Runtime.InteropServices;

namespace Simply_add_a_license.Commands
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class Simply_add_a_license
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("25afcc80-53c9-469e-b4f5-77edf8d8fe72");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;

        /// <summary>
        /// Initializes a new instance of the <see cref="Simply_add_a_license"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private Simply_add_a_license(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static Simply_add_a_license Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in Simply_add_a_license's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new Simply_add_a_license(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            try
            {
                var dte2 = (DTE2)(Marshal.GetActiveObject("VisualStudio.DTE.17.0") ?? Marshal.GetActiveObject("VisualStudio.DTE.16.0"));
                var solutionDir = Directory.GetParent(dte2.Solution.FullName);
                var licenseWindow = new SimplyAddALicenseWindow() { Solutionpath = solutionDir };
                licenseWindow.Show();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(
                    "You must open a solution to add a license",
                    "Open a Visual Studio solution",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}