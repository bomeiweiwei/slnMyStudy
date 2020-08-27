using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// sysdiagrams class
    /// </summary>
    [MetadataType(typeof(sysdiagramsMD))]
    public partial class sysdiagrams
    {
    
    	/// <summary>
    	/// sysdiagrams Metadata class
    	/// </summary>
    	public class sysdiagramsMD
    	{
    		    
    		/// <summary>
    		/// name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("name", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(128, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string name { get; set; }
    
    		    
    		/// <summary>
    		/// principal_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("principal_id", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int principal_id { get; set; }
    
    		    
    		/// <summary>
    		/// diagram_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("diagram_id", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int diagram_id { get; set; }
    
    		    
    		/// <summary>
    		/// version
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("version", typeof(NorthWindResource))]
    		public Nullable<int> version { get; set; }
    
    		    
    		/// <summary>
    		/// definition
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("definition", typeof(NorthWindResource))]
    		public byte[] definition { get; set; }
    
    		    
    	}
    }
    
}
