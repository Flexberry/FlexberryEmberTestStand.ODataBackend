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
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Suggestion type.
    /// </summary>
    // *** Start programmer edit section *** (SuggestionType CustomAttributes)

    // *** End programmer edit section *** (SuggestionType CustomAttributes)
    [AutoAltered()]
    [Caption("Suggestion type")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "Name as \'Name\'",
            "Moderated as \'Moderated\'",
            "Parent as \'Parent\'",
            "Parent.Name as \'Name\'"})]
    [AssociatedDetailViewAttribute("AuditView", "LocalizedTypes", "AuditView", true, "", "Localized types", true, new string[] {
            ""})]
    [View("SuggestionTypeE", new string[] {
            "Name as \'Name\'",
            "Moderated as \'Moderated\'",
            "Parent as \'Parent\'",
            "Parent.Name as \'Name\'"}, Hidden=new string[] {
            "Parent.Name"})]
    [AssociatedDetailViewAttribute("SuggestionTypeE", "LocalizedTypes", "LocalizedSuggestionTypeE", true, "", "Localized types", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("SuggestionTypeE", "Parent", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("SuggestionTypeL", new string[] {
            "Name as \'Name\'",
            "Moderated as \'Moderated\'",
            "Parent as \'Parent\'",
            "Parent.Name as \'Name\'"}, Hidden=new string[] {
            "Parent.Name"})]
    [MasterViewDefineAttribute("SuggestionTypeL", "Parent", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    public class SuggestionType : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private string fName;
        
        private bool fModerated;
        
        private EmberFlexberryDummy.SuggestionType fParent;
        
        private EmberFlexberryDummy.DetailArrayOfLocalizedSuggestionType fLocalizedTypes;
        
        // *** Start programmer edit section *** (SuggestionType CustomMembers)

        // *** End programmer edit section *** (SuggestionType CustomMembers)

        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.CreateTime CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.CreateTime Get start)

                // *** End programmer edit section *** (SuggestionType.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (SuggestionType.CreateTime Get end)

                // *** End programmer edit section *** (SuggestionType.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.CreateTime Set start)

                // *** End programmer edit section *** (SuggestionType.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (SuggestionType.CreateTime Set end)

                // *** End programmer edit section *** (SuggestionType.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.Creator CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.Creator CustomAttributes)
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.Creator Get start)

                // *** End programmer edit section *** (SuggestionType.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (SuggestionType.Creator Get end)

                // *** End programmer edit section *** (SuggestionType.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.Creator Set start)

                // *** End programmer edit section *** (SuggestionType.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (SuggestionType.Creator Set end)

                // *** End programmer edit section *** (SuggestionType.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.EditTime CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.EditTime Get start)

                // *** End programmer edit section *** (SuggestionType.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (SuggestionType.EditTime Get end)

                // *** End programmer edit section *** (SuggestionType.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.EditTime Set start)

                // *** End programmer edit section *** (SuggestionType.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (SuggestionType.EditTime Set end)

                // *** End programmer edit section *** (SuggestionType.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.Editor CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.Editor CustomAttributes)
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.Editor Get start)

                // *** End programmer edit section *** (SuggestionType.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (SuggestionType.Editor Get end)

                // *** End programmer edit section *** (SuggestionType.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.Editor Set start)

                // *** End programmer edit section *** (SuggestionType.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (SuggestionType.Editor Set end)

                // *** End programmer edit section *** (SuggestionType.Editor Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.Name CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.Name CustomAttributes)
        [NotNull()]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.Name Get start)

                // *** End programmer edit section *** (SuggestionType.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (SuggestionType.Name Get end)

                // *** End programmer edit section *** (SuggestionType.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.Name Set start)

                // *** End programmer edit section *** (SuggestionType.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (SuggestionType.Name Set end)

                // *** End programmer edit section *** (SuggestionType.Name Set end)
            }
        }
        
        /// <summary>
        /// Moderated.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.Moderated CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.Moderated CustomAttributes)
        public virtual bool Moderated
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.Moderated Get start)

                // *** End programmer edit section *** (SuggestionType.Moderated Get start)
                bool result = this.fModerated;
                // *** Start programmer edit section *** (SuggestionType.Moderated Get end)

                // *** End programmer edit section *** (SuggestionType.Moderated Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.Moderated Set start)

                // *** End programmer edit section *** (SuggestionType.Moderated Set start)
                this.fModerated = value;
                // *** Start programmer edit section *** (SuggestionType.Moderated Set end)

                // *** End programmer edit section *** (SuggestionType.Moderated Set end)
            }
        }
        
        /// <summary>
        /// Suggestion type.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.Parent CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.Parent CustomAttributes)
        [PropertyStorage(new string[] {
                "Parent"})]
        public virtual EmberFlexberryDummy.SuggestionType Parent
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.Parent Get start)

                // *** End programmer edit section *** (SuggestionType.Parent Get start)
                EmberFlexberryDummy.SuggestionType result = this.fParent;
                // *** Start programmer edit section *** (SuggestionType.Parent Get end)

                // *** End programmer edit section *** (SuggestionType.Parent Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.Parent Set start)

                // *** End programmer edit section *** (SuggestionType.Parent Set start)
                this.fParent = value;
                // *** Start programmer edit section *** (SuggestionType.Parent Set end)

                // *** End programmer edit section *** (SuggestionType.Parent Set end)
            }
        }
        
        /// <summary>
        /// Suggestion type.
        /// </summary>
        // *** Start programmer edit section *** (SuggestionType.LocalizedTypes CustomAttributes)

        // *** End programmer edit section *** (SuggestionType.LocalizedTypes CustomAttributes)
        public virtual EmberFlexberryDummy.DetailArrayOfLocalizedSuggestionType LocalizedTypes
        {
            get
            {
                // *** Start programmer edit section *** (SuggestionType.LocalizedTypes Get start)

                // *** End programmer edit section *** (SuggestionType.LocalizedTypes Get start)
                if ((this.fLocalizedTypes == null))
                {
                    this.fLocalizedTypes = new EmberFlexberryDummy.DetailArrayOfLocalizedSuggestionType(this);
                }
                EmberFlexberryDummy.DetailArrayOfLocalizedSuggestionType result = this.fLocalizedTypes;
                // *** Start programmer edit section *** (SuggestionType.LocalizedTypes Get end)

                // *** End programmer edit section *** (SuggestionType.LocalizedTypes Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SuggestionType.LocalizedTypes Set start)

                // *** End programmer edit section *** (SuggestionType.LocalizedTypes Set start)
                this.fLocalizedTypes = value;
                // *** Start programmer edit section *** (SuggestionType.LocalizedTypes Set end)

                // *** End programmer edit section *** (SuggestionType.LocalizedTypes Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(EmberFlexberryDummy.SuggestionType));
                }
            }
            
            /// <summary>
            /// "SuggestionTypeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SuggestionTypeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SuggestionTypeE", typeof(EmberFlexberryDummy.SuggestionType));
                }
            }
            
            /// <summary>
            /// "SuggestionTypeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SuggestionTypeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SuggestionTypeL", typeof(EmberFlexberryDummy.SuggestionType));
                }
            }
        }
    }
}