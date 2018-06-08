﻿using Cake.Core;
using Cake.Core.IO;

namespace Cake.Npm.Ci
{
    /// <summary>
    /// Contains settings used by <see cref="NpmCiTool"/>.
    /// </summary>
    public class NpmCiSettings : NpmSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpmCiSettings"/> class.
        /// </summary>
        public NpmCiSettings()
            : base("ci")
        {
        }

        /// <summary>
        /// Gets a value indicating whether npm should ignore modules listed in <code>devDependencies</code>.
        /// </summary>
        public bool Production { get; set; }

        /// <summary>
        /// Evaluates the settings and writes them to <paramref name="args"/>.
        /// </summary>
        /// <param name="args">The argument builder into which the settings should be written.</param>
        protected override void EvaluateCore(ProcessArgumentBuilder args)
        {
            base.EvaluateCore(args);

            if (Production)
            {
                args.Append("--production");
            }
        }
    }
}
