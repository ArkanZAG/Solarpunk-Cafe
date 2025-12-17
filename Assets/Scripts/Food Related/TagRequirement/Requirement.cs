using System.Collections.Generic;

namespace Food_Related.TagRequirement
{
    public abstract class Requirement
    {
        public abstract bool IsAvailable(List<Ingredients> ingredient);
    }
}