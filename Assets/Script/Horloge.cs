using System;
using UnityEngine;

namespace Script
{
    public class Horloge : ATimelineDependent
    {
        [SerializeField] private TMPro.TextMeshProUGUI minutes;
        [SerializeField] private TMPro.TextMeshProUGUI seconds;

        public override void TimelineUpdate(float t, bool manual)
        {
            if (GameManager.Ready)
                UpdateTime(t * GameManager.TotalDuration);
        }

        private void UpdateTime(float t)
        {
            var ts = TimeSpan.FromMilliseconds(t);
            var m = $"{ts.Minutes:00}";
            var s = $"{ts.Seconds:00}:{ts.Milliseconds / 10:00}";
            minutes.text = m;
            seconds.text = s;
        }
    }
}