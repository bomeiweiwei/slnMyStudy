using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Vote_Auto class
    /// </summary>
    [MetadataType(typeof(Vote_AutoMD))]
    public partial class Vote_Auto
    {
    
    	/// <summary>
    	/// Vote_Auto Metadata class
    	/// </summary>
    	public class Vote_AutoMD
    	{
    		    
    		/// <summary>
    		/// vote_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_id { get; set; }
    
    		    
    		/// <summary>
    		/// Vote_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Vote_time", typeof(testResource))]
    		public Nullable<System.DateTime> Vote_time { get; set; }
    
    		    
    		/// <summary>
    		/// title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("title", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string title { get; set; }
    
    		    
    		/// <summary>
    		/// question_1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_1", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_1 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_1", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_1 { get; set; }
    
    		    
    		/// <summary>
    		/// question_2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_2", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_2 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_2", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_2 { get; set; }
    
    		    
    		/// <summary>
    		/// question_3
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_3", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_3 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_3
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_3", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_3 { get; set; }
    
    		    
    		/// <summary>
    		/// question_4
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_4", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_4 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_4
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_4", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_4 { get; set; }
    
    		    
    		/// <summary>
    		/// question_5
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_5", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_5 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_5
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_5", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_5 { get; set; }
    
    		    
    		/// <summary>
    		/// question_6
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_6", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_6 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_6
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_6", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_6 { get; set; }
    
    		    
    		/// <summary>
    		/// question_7
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_7", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_7 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_7
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_7", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_7 { get; set; }
    
    		    
    		/// <summary>
    		/// question_8
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_8", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_8 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_8
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_8", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_8 { get; set; }
    
    		    
    		/// <summary>
    		/// question_9
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_9", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_9 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_9
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_9", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_9 { get; set; }
    
    		    
    		/// <summary>
    		/// question_10
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_10", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string question_10 { get; set; }
    
    		    
    		/// <summary>
    		/// answer_10
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("answer_10", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int answer_10 { get; set; }
    
    		    
    		/// <summary>
    		/// question_all
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("question_all", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int question_all { get; set; }
    
    		    
    	}
    }
    
}
