//     Copyright (C) 2016 Rethought
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//     Created: 04.10.2016 1:05 PM
//     Last Edited: 04.10.2016 1:43 PM

using EloBuddy; 
using LeagueSharp.Common; 
namespace RethoughtLib.Core
{
    #region Using Directives

    using global::RethoughtLib.FeatureSystem.Abstract_Classes;
    using global::RethoughtLib.VersionChecker.Implementations;

    #endregion

    internal sealed class RethoughtLibModule : ParentBase
    {
        #region Constructors and Destructors

        #region Constructors

        public RethoughtLibModule(VersionCheckerModule versionCheckerModule = null)
        {
            var versionChecker = versionCheckerModule ?? new VersionCheckerModule("", this.Name);

            versionChecker.GithubPath =
                "https://github.com/MediaGithub/LeagueSharpDev/tree/master/LeagueSharp/RethoughtLib";

            this.Add(versionChecker);
        }

        #endregion

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public override string Name { get; set; } = nameof(RethoughtLib);

        #endregion
    }
}