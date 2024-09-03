using Nuake.Net;

namespace $rootnamespace$
{
    [PointScript("This is a point entity reflected in Trenchbroom")]
    class $safeitemrootname$ : Entity
    {
        // Note: This is also an entity script which has the typical update methods
        // public override void OnFixedUpdate(float dt)

        public override void Activate(Entity invoker)
        {
            // Activates all its targets
            foreach (Entity target in Targets)
            {
                target.Activate(triggeredFrom); // Relay the original invoker
            }
        }
    }
}