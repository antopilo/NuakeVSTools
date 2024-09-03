using Nuake.Net;

namespace $rootnamespace$
{
    [BrushScript("This is a trigger", IsTrigger = true)]
    class $safeitemrootname$ : Entity
    {
        public override void Activate(Entity invoker)
        {
            // Can also be activated..
        }

        public virtual void OnCollision(Entity entity)
        {
            // Activates all its targets when a collision is detected
            foreach (Entity target in Targets)
            {
                target.Activate(triggeredFrom);
            }
        }
    }
}