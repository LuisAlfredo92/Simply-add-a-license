using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simply_add_a_license.Commands
{
    /// <summary>
    /// The license class that contains all the information about
    /// the license like name, path, text, more info URL, etc.
    /// </summary>
    internal class License
    {
        /// <summary>
        /// Gets or Sets the license id. E.g. "0BSD"
        /// </summary>
        public string LicenseId { get; set; }

        /// <summary>
        /// Gets or Sets the name of the license. E.g. "BSD Zero Clause License"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets the text of the license, the main part of it, the body.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets the URL of the license information. E.g. "https://opensource.org/licences/0BSD".
        /// Licenses on json files can have more than one link, however, I'll try to use the
        /// opensource.org page as much as possible
        /// </summary>
        public string MoreInfoLink { get; set; }

        /// <summary>
        /// Ful name of the license, composed of ID + Name.
        /// E.g. "0BSD - BSD Zero Clause License"
        /// </summary>
        public string FullName { get => $"({LicenseId})\n{Name}"; }

        /// <summary>
        /// Initializes a new instance of the <see cref="License"/> class.
        /// </summary>
        /// <param name="LicenseId">The identifier of the license.</param>
        /// <param name="name">The name of the license.</param>
        /// <param name="text">The body of the license.</param>
        /// <param name="moreInfoLink">The URL to get more info about the license.</param>
        public License(string licenseId, string name, string text, string moreInfoLink)
        {
            LicenseId = licenseId ?? throw new ArgumentNullException(nameof(licenseId));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
            MoreInfoLink = moreInfoLink;
        }
    }
}
