using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace Fireflies
{
    public class Firefly : Pawn
    {
        private Comp_Firefly compFirefly;

        public override void SpawnSetup(Map map, bool respawningAfterLoad)
        {
            base.SpawnSetup(map, respawningAfterLoad);
            compFirefly = this.TryGetComp<Comp_Firefly>();
        }

        public override Vector3 DrawPos => base.DrawPos + (compFirefly?.FireflyPos ?? Vector3.zero);
    }
}
