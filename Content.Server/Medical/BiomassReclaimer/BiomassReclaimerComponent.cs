namespace Content.Server.Medical.BiomassReclaimer
{
    [RegisterComponent]
    public sealed class BiomassReclaimerComponent : Component
    {
        [DataField("accumulator")]
        public float Accumulator = 0f;

        /// <summary>
        /// This gets set for each mob it processes.
        /// When accumulator hits this, spit out biomass.
        /// </summary>
        public float CurrentProcessingTime = 70f;

        /// <summary>
        /// This is calculated from the YieldPerUnitMass
        /// and adjusted for genetic damage too.
        /// </summary>
        public float CurrentExpectedYield = 17.5f;

        /// <summary>
        /// How many units of biomass it produces for each unit of mass.
        /// </summary>
        public float YieldPerUnitMass = 0.25f;

        /// <summary>
        /// Will this refuse to gib a living mob?
        /// </summary>
        public bool SafetyEnabled = true;
    }
}
