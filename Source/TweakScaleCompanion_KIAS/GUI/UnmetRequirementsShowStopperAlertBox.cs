﻿/*
	This file is part of TweakScaleCompanion_KIAS
		© 2020-2023 LisiasT : http://lisias.net <me@lisias.net>

	TweakScaleCompanion_KIAS is double licensed, as follows:
		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	TweakScaleCompanion_KIAS is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with TweakScaleCompanion_KIAS. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with TweakScaleCompanion_KIAS. If not, see <https://www.gnu.org/licenses/>.

*/
using UnityEngine;
using KSPe.UI;

namespace TweakScaleCompanion.KIAS.GUI
{
	internal class UnmetRequirementsShowStopperAlertBox
	{
		private const string URL = "https://ksp.lisias.net/add-ons/TweakScaleCompanion/Support/KIAS/unmet-requirements";
		private static readonly string MSG = @"Unfortunately TweakScale Companion KIAS is unable to proceed due unmet requiments!

You need to have {0} installed, otherwise this Companion will fail to install itself and KSP will inject bad information on your savegames' KIS and KAS parts with TwekScale.

If you decide to proceed, do it with caution - backup anything valuable in your savegames.";

		private static readonly string AMSG = @"go to TweakScale Companion Program's page, look for the dependencies for KIAS, download and install {0} and restart KSP (it will close now)";

		internal static void Show(string failedRequirement)
		{
			KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
				string.Format(MSG, failedRequirement),
				string.Format(AMSG, failedRequirement),
				() => { KSPe.Util.CkanTools.OpenURL(URL); Application.Quit(); }
			);
			Log.detail("\"Houston, we have a Problem!\" about unmet dependencies was displayed");
		}
    }
}

