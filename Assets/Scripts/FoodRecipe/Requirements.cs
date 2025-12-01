namespace FoodRecipe
{
    [System.Serializable]
    public class Requirements
    {
        public RequirementSpecificType requirementSpecificType;
        public RequireGeneralType requirementGeneralType;
        public int quantity = 0;
        
        public enum RequirementSpecificType
        {
            None,
            Banana,
            Cassava,
            Clams,
        }

        public enum RequireGeneralType
        {
            None,
            AnyProtein,
            AnyFat,
            AnySugar,
            AnyFiber,
            AnyCarbs,
            AnyFlour,
        }
    }
}