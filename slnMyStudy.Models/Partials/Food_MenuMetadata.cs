using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Food_Menu class
    /// </summary>
    [MetadataType(typeof(Food_MenuMD))]
    public partial class Food_Menu
    {
    
    	/// <summary>
    	/// Food_Menu Metadata class
    	/// </summary>
    	public class Food_MenuMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// food_class
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("food_class", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string food_class { get; set; }
    
    		    
    		/// <summary>
    		/// food_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("food_name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string food_name { get; set; }
    
    		    
    	}
    }
    
}
