using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Food_Calorie class
    /// </summary>
    [MetadataType(typeof(Food_CalorieMD))]
    public partial class Food_Calorie
    {
    
    	/// <summary>
    	/// Food_Calorie Metadata class
    	/// </summary>
    	public class Food_CalorieMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// food_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("food_name", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string food_name { get; set; }
    
    		    
    		/// <summary>
    		/// food_unit
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("food_unit", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string food_unit { get; set; }
    
    		    
    		/// <summary>
    		/// food_ Calorie1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("food_Calorie1", typeof(testResource))]
    		public Nullable<int> food_Calorie1 { get; set; }
    
    		    
    	}
    }
    
}
