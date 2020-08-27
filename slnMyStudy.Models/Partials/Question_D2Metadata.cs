using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Question_D2 class
    /// </summary>
    [MetadataType(typeof(Question_D2MD))]
    public partial class Question_D2
    {
    
    	/// <summary>
    	/// Question_D2 Metadata class
    	/// </summary>
    	public class Question_D2MD
    	{
    		    
    		/// <summary>
    		/// D2_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D2_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int D2_id { get; set; }
    
    		    
    		/// <summary>
    		/// D1_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D1_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int D1_id { get; set; }
    
    		    
    		/// <summary>
    		/// M_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("M_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int M_id { get; set; }
    
    		    
    		/// <summary>
    		/// answer1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer1", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer1 { get; set; }
    
    		    
    		/// <summary>
    		/// answer2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer2", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer2 { get; set; }
    
    		    
    		/// <summary>
    		/// answer3
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer3", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer3 { get; set; }
    
    		    
    		/// <summary>
    		/// answer4
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer4", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer4 { get; set; }
    
    		    
    		/// <summary>
    		/// answer5
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer5", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer5 { get; set; }
    
    		    
    		/// <summary>
    		/// answer6
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer6", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer6 { get; set; }
    
    		    
    		/// <summary>
    		/// answer7
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer7", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer7 { get; set; }
    
    		    
    		/// <summary>
    		/// answer8
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer8", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer8 { get; set; }
    
    		    
    		/// <summary>
    		/// answer9
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer9", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer9 { get; set; }
    
    		    
    		/// <summary>
    		/// answer10
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer10", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer10 { get; set; }
    
    		    
    		/// <summary>
    		/// answer11
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer11", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer11 { get; set; }
    
    		    
    		/// <summary>
    		/// answer12
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer12", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer12 { get; set; }
    
    		    
    		/// <summary>
    		/// answer13
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer13", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer13 { get; set; }
    
    		    
    		/// <summary>
    		/// answer14
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer14", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer14 { get; set; }
    
    		    
    		/// <summary>
    		/// answer15
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer15", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string answer15 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_all
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_all", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_all { get; set; }
    
    		    
    	}
    }
    
}
