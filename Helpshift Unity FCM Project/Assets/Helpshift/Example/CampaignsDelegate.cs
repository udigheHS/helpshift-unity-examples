using System;
using Helpshift;
using UnityEngine;

namespace HelpshiftExample
{
	public class CampaignsDelegate : IHelpshiftCampaignsDelegate
	{
		public void didReceiveUnreadMessagesCount(int count) {
			Debug.Log ("Campaigns : didReceiveUnreadMessagesCount : " + count);
		}
	}
}
