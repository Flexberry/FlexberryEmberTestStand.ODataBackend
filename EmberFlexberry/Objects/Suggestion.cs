﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmberFlexberryDummy
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Suggestion.
    /// </summary>
    // *** Start programmer edit section *** (Suggestion CustomAttributes)

    // *** End programmer edit section *** (Suggestion CustomAttributes)
    [BusinessServer("EmberFlexberryDummy.ApplicationBS, EmberFlexberry.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "Address as \'Address\'",
            "Text as \'Text\'",
            "Date as \'Date\'",
            "Votes as \'Votes\'",
            "Moderated as \'Moderated\'",
            "Type as \'Type\'",
            "Type.Name as \'Name\'",
            "Author as \'Author\'",
            "Author.Name as \'Name\'"})]
    [AssociatedDetailViewAttribute("AuditView", "Files", "AuditView", true, "", "Files", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("AuditView", "Comments", "AuditView", true, "", "Comments", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("AuditView", "UserVotes", "AuditView", true, "", "User votes", true, new string[] {
            ""})]
    [View("SuggestionE", new string[] {
            "Address as \'Address\'",
            "Text as \'Text\'",
            "Date as \'Date\'",
            "Votes as \'Votes\'",
            "Moderated as \'Moderated\'",
            "Type as \'Type\'",
            "Type.Name as \'Name\'",
            "Author as \'Author\'",
            "Author.Name as \'Name\'",
            "Editor1 as \'Editor1\'",
            "Editor1.Name as \'Name\'",
            "CreateTime",
            "Creator",
            "EditTime",
            "Editor"}, Hidden=new string[] {
            "Type.Name",
            "Author.Name",
            "Editor1.Name",
            "CreateTime",
            "Creator",
            "EditTime",
            "Editor"})]
    [AssociatedDetailViewAttribute("SuggestionE", "Files", "SuggestionFileE", true, "", "Files", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("SuggestionE", "UserVotes", "VoteE", true, "", "User votes", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("SuggestionE", "Comments", "CommentD", true, "", "Comments", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("SuggestionE", "Type", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [MasterViewDefineAttribute("SuggestionE", "Author", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("SuggestionEWithComputedField", new string[] {
            "Address",
            "Text",
            "Date",
            "Votes",
            "Moderated",
            "Author",
            "Author.Name",
            "Type",
            "Type.Name",
            "Type.Moderated",
            "Type.ComputedField",
            "Editor1",
            "Editor1.Name",
            "CreateTime",
            "Creator",
            "EditTime",
            "Editor"})]
    [View("SuggestionL", new string[] {
            "Address as \'Address\'",
            "Text as \'Text\'",
            "Date as \'Date\'",
            "Votes as \'Votes\'",
            "Moderated as \'Moderated\'",
            "Type",
            "Type.Name as \'Name\'",
            "Author",
            "Author.Name as \'Name\'",
            "Editor1",
            "Editor1.Name as \'Name\'",
            "CreateTime",
            "Creator",
            "EditTime",
            "Editor",
            "CommentsCount as \'Comments Count\'"}, Hidden=new string[] {
            "Type.Name",
            "Author.Name",
            "Editor1.Name",
            "CreateTime",
            "Creator",
            "EditTime",
            "Editor"})]
    [AssociatedDetailViewAttribute("SuggestionL", "Comments", "CommentD", true, "", "", false, new string[] {
            ""})]
    [MasterViewDefineAttribute("SuggestionL", "Type", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [MasterViewDefineAttribute("SuggestionL", "Author", ICSSoft.STORMNET.LookupTypeEnum.Combo, "", "Name")]
    [MasterViewDefineAttribute("SuggestionL", "Editor1", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    public class Suggestion : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private string fAddress;
        
        private string fText;
        
        private System.DateTime fDate = System.DateTime.UtcNow;
        
        private long fVotes;
        
        private bool fModerated;
        
        private EmberFlexberryDummy.ApplicationUser fAuthor;
        
        private EmberFlexberryDummy.ApplicationUser fEditor1;
        
        private EmberFlexberryDummy.SuggestionType fType;
        
        private EmberFlexberryDummy.DetailArrayOfComment fComments;
        
        private EmberFlexberryDummy.DetailArrayOfSuggestionFile fFiles;
        
        private EmberFlexberryDummy.DetailArrayOfVote fUserVotes;
        
        // *** Start programmer edit section *** (Suggestion CustomMembers)

        /// <summary>
        /// Cash value for CommentsCount field.
        /// </summary>
        private ICSSoft.STORMNET.UserDataTypes.NullableInt cashedCommentsCount = null;
        
        // *** End programmer edit section *** (Suggestion CustomMembers)

        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.CreateTime CustomAttributes)

        // *** End programmer edit section *** (Suggestion.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.CreateTime Get start)

                // *** End programmer edit section *** (Suggestion.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (Suggestion.CreateTime Get end)

                // *** End programmer edit section *** (Suggestion.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.CreateTime Set start)

                // *** End programmer edit section *** (Suggestion.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (Suggestion.CreateTime Set end)

                // *** End programmer edit section *** (Suggestion.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Creator CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Creator CustomAttributes)
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Creator Get start)

                // *** End programmer edit section *** (Suggestion.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (Suggestion.Creator Get end)

                // *** End programmer edit section *** (Suggestion.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Creator Set start)

                // *** End programmer edit section *** (Suggestion.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (Suggestion.Creator Set end)

                // *** End programmer edit section *** (Suggestion.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.EditTime CustomAttributes)

        // *** End programmer edit section *** (Suggestion.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.EditTime Get start)

                // *** End programmer edit section *** (Suggestion.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (Suggestion.EditTime Get end)

                // *** End programmer edit section *** (Suggestion.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.EditTime Set start)

                // *** End programmer edit section *** (Suggestion.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (Suggestion.EditTime Set end)

                // *** End programmer edit section *** (Suggestion.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Editor CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Editor CustomAttributes)
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Editor Get start)

                // *** End programmer edit section *** (Suggestion.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (Suggestion.Editor Get end)

                // *** End programmer edit section *** (Suggestion.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Editor Set start)

                // *** End programmer edit section *** (Suggestion.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (Suggestion.Editor Set end)

                // *** End programmer edit section *** (Suggestion.Editor Set end)
            }
        }
        
        /// <summary>
        /// Address.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Address CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Address CustomAttributes)
        public virtual string Address
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Address Get start)

                // *** End programmer edit section *** (Suggestion.Address Get start)
                string result = this.fAddress;
                // *** Start programmer edit section *** (Suggestion.Address Get end)

                // *** End programmer edit section *** (Suggestion.Address Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Address Set start)

                // *** End programmer edit section *** (Suggestion.Address Set start)
                this.fAddress = value;
                // *** Start programmer edit section *** (Suggestion.Address Set end)

                // *** End programmer edit section *** (Suggestion.Address Set end)
            }
        }
        
        /// <summary>
        /// Text.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Text CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Text CustomAttributes)
        public virtual string Text
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Text Get start)

                // *** End programmer edit section *** (Suggestion.Text Get start)
                string result = this.fText;
                // *** Start programmer edit section *** (Suggestion.Text Get end)

                // *** End programmer edit section *** (Suggestion.Text Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Text Set start)

                // *** End programmer edit section *** (Suggestion.Text Set start)
                this.fText = value;
                // *** Start programmer edit section *** (Suggestion.Text Set end)

                // *** End programmer edit section *** (Suggestion.Text Set end)
            }
        }
        
        /// <summary>
        /// Date.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Date CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Date CustomAttributes)
        [NotNull()]
        public virtual System.DateTime Date
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Date Get start)

                // *** End programmer edit section *** (Suggestion.Date Get start)
                System.DateTime result = this.fDate;
                // *** Start programmer edit section *** (Suggestion.Date Get end)

                // *** End programmer edit section *** (Suggestion.Date Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Date Set start)

                // *** End programmer edit section *** (Suggestion.Date Set start)
                this.fDate = value;
                // *** Start programmer edit section *** (Suggestion.Date Set end)

                // *** End programmer edit section *** (Suggestion.Date Set end)
            }
        }
        
        /// <summary>
        /// Votes.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Votes CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Votes CustomAttributes)
        public virtual long Votes
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Votes Get start)

                // *** End programmer edit section *** (Suggestion.Votes Get start)
                long result = this.fVotes;
                // *** Start programmer edit section *** (Suggestion.Votes Get end)

                // *** End programmer edit section *** (Suggestion.Votes Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Votes Set start)

                // *** End programmer edit section *** (Suggestion.Votes Set start)
                this.fVotes = value;
                // *** Start programmer edit section *** (Suggestion.Votes Set end)

                // *** End programmer edit section *** (Suggestion.Votes Set end)
            }
        }
        
        /// <summary>
        /// Moderated.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Moderated CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Moderated CustomAttributes)
        public virtual bool Moderated
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Moderated Get start)

                // *** End programmer edit section *** (Suggestion.Moderated Get start)
                bool result = this.fModerated;
                // *** Start programmer edit section *** (Suggestion.Moderated Get end)

                // *** End programmer edit section *** (Suggestion.Moderated Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Moderated Set start)

                // *** End programmer edit section *** (Suggestion.Moderated Set start)
                this.fModerated = value;
                // *** Start programmer edit section *** (Suggestion.Moderated Set end)

                // *** End programmer edit section *** (Suggestion.Moderated Set end)
            }
        }
        
        /// <summary>
        /// CommentsCount.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.CommentsCount CustomAttributes)

        // *** End programmer edit section *** (Suggestion.CommentsCount CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.SQLDataService), "SELECT COUNT(*) FROM Suggestion join Comment on Suggestion.primaryKey = Comment.S" +
            "uggestion WHERE Comment.Suggestion = StormMainObjectKey")]
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableInt CommentsCount
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.CommentsCount Get)
               return this.cashedCommentsCount;
                // *** End programmer edit section *** (Suggestion.CommentsCount Get)
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.CommentsCount Set)
                if (value != null)
                {
                    this.cashedCommentsCount = value;
                }
                // *** End programmer edit section *** (Suggestion.CommentsCount Set)
            }
        }
        
        /// <summary>
        /// Suggestion.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Author CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Author CustomAttributes)
        [PropertyStorage(new string[] {
                "Author"})]
        [NotNull()]
        public virtual EmberFlexberryDummy.ApplicationUser Author
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Author Get start)

                // *** End programmer edit section *** (Suggestion.Author Get start)
                EmberFlexberryDummy.ApplicationUser result = this.fAuthor;
                // *** Start programmer edit section *** (Suggestion.Author Get end)

                // *** End programmer edit section *** (Suggestion.Author Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Author Set start)

                // *** End programmer edit section *** (Suggestion.Author Set start)
                this.fAuthor = value;
                // *** Start programmer edit section *** (Suggestion.Author Set end)

                // *** End programmer edit section *** (Suggestion.Author Set end)
            }
        }
        
        /// <summary>
        /// Suggestion.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Editor1 CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Editor1 CustomAttributes)
        [PropertyStorage(new string[] {
                "Editor1"})]
        [NotNull()]
        public virtual EmberFlexberryDummy.ApplicationUser Editor1
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Editor1 Get start)

                // *** End programmer edit section *** (Suggestion.Editor1 Get start)
                EmberFlexberryDummy.ApplicationUser result = this.fEditor1;
                // *** Start programmer edit section *** (Suggestion.Editor1 Get end)

                // *** End programmer edit section *** (Suggestion.Editor1 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Editor1 Set start)

                // *** End programmer edit section *** (Suggestion.Editor1 Set start)
                this.fEditor1 = value;
                // *** Start programmer edit section *** (Suggestion.Editor1 Set end)

                // *** End programmer edit section *** (Suggestion.Editor1 Set end)
            }
        }
        
        /// <summary>
        /// Suggestion.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Type CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Type CustomAttributes)
        [PropertyStorage(new string[] {
                "Type"})]
        [NotNull()]
        public virtual EmberFlexberryDummy.SuggestionType Type
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Type Get start)

                // *** End programmer edit section *** (Suggestion.Type Get start)
                EmberFlexberryDummy.SuggestionType result = this.fType;
                // *** Start programmer edit section *** (Suggestion.Type Get end)

                // *** End programmer edit section *** (Suggestion.Type Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Type Set start)

                // *** End programmer edit section *** (Suggestion.Type Set start)
                this.fType = value;
                // *** Start programmer edit section *** (Suggestion.Type Set end)

                // *** End programmer edit section *** (Suggestion.Type Set end)
            }
        }
        
        /// <summary>
        /// Suggestion.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Comments CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Comments CustomAttributes)
        public virtual EmberFlexberryDummy.DetailArrayOfComment Comments
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Comments Get start)

                // *** End programmer edit section *** (Suggestion.Comments Get start)
                if ((this.fComments == null))
                {
                    this.fComments = new EmberFlexberryDummy.DetailArrayOfComment(this);
                }
                EmberFlexberryDummy.DetailArrayOfComment result = this.fComments;
                // *** Start programmer edit section *** (Suggestion.Comments Get end)

                // *** End programmer edit section *** (Suggestion.Comments Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Comments Set start)

                // *** End programmer edit section *** (Suggestion.Comments Set start)
                this.fComments = value;
                // *** Start programmer edit section *** (Suggestion.Comments Set end)

                // *** End programmer edit section *** (Suggestion.Comments Set end)
            }
        }
        
        /// <summary>
        /// Suggestion.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.Files CustomAttributes)

        // *** End programmer edit section *** (Suggestion.Files CustomAttributes)
        public virtual EmberFlexberryDummy.DetailArrayOfSuggestionFile Files
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.Files Get start)

                // *** End programmer edit section *** (Suggestion.Files Get start)
                if ((this.fFiles == null))
                {
                    this.fFiles = new EmberFlexberryDummy.DetailArrayOfSuggestionFile(this);
                }
                EmberFlexberryDummy.DetailArrayOfSuggestionFile result = this.fFiles;
                // *** Start programmer edit section *** (Suggestion.Files Get end)

                // *** End programmer edit section *** (Suggestion.Files Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.Files Set start)

                // *** End programmer edit section *** (Suggestion.Files Set start)
                this.fFiles = value;
                // *** Start programmer edit section *** (Suggestion.Files Set end)

                // *** End programmer edit section *** (Suggestion.Files Set end)
            }
        }
        
        /// <summary>
        /// Suggestion.
        /// </summary>
        // *** Start programmer edit section *** (Suggestion.UserVotes CustomAttributes)

        // *** End programmer edit section *** (Suggestion.UserVotes CustomAttributes)
        public virtual EmberFlexberryDummy.DetailArrayOfVote UserVotes
        {
            get
            {
                // *** Start programmer edit section *** (Suggestion.UserVotes Get start)

                // *** End programmer edit section *** (Suggestion.UserVotes Get start)
                if ((this.fUserVotes == null))
                {
                    this.fUserVotes = new EmberFlexberryDummy.DetailArrayOfVote(this);
                }
                EmberFlexberryDummy.DetailArrayOfVote result = this.fUserVotes;
                // *** Start programmer edit section *** (Suggestion.UserVotes Get end)

                // *** End programmer edit section *** (Suggestion.UserVotes Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Suggestion.UserVotes Set start)

                // *** End programmer edit section *** (Suggestion.UserVotes Set start)
                this.fUserVotes = value;
                // *** Start programmer edit section *** (Suggestion.UserVotes Set end)

                // *** End programmer edit section *** (Suggestion.UserVotes Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(EmberFlexberryDummy.Suggestion));
                }
            }
            
            /// <summary>
            /// "SuggestionE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SuggestionE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SuggestionE", typeof(EmberFlexberryDummy.Suggestion));
                }
            }
            
            /// <summary>
            /// "SuggestionEWithComputedField" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SuggestionEWithComputedField
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SuggestionEWithComputedField", typeof(EmberFlexberryDummy.Suggestion));
                }
            }
            
            /// <summary>
            /// "SuggestionL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SuggestionL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SuggestionL", typeof(EmberFlexberryDummy.Suggestion));
                }
            }
        }
    }
}
