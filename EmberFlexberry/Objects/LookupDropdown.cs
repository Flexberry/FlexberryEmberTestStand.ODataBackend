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
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// LookupDropdown.
    /// </summary>
    // *** Start programmer edit section *** (LookupDropdown CustomAttributes)

    // *** End programmer edit section *** (LookupDropdown CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("LookupDropdown", new string[] {
            "Name",
            "MasterLookupDropdown as \'Master lookup dropdown\'",
            "MasterLookupDropdown.Text"}, Hidden=new string[] {
            "Name",
            "MasterLookupDropdown.Text"})]
    [MasterViewDefineAttribute("LookupDropdown", "MasterLookupDropdown", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Text")]
    public class LookupDropdown : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private EmberFlexberryDummy.MasterLookupDropdown fMasterLookupDropdown;
        
        // *** Start programmer edit section *** (LookupDropdown CustomMembers)

        // *** End programmer edit section *** (LookupDropdown CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (LookupDropdown.Name CustomAttributes)

        // *** End programmer edit section *** (LookupDropdown.Name CustomAttributes)
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (LookupDropdown.Name Get start)

                // *** End programmer edit section *** (LookupDropdown.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (LookupDropdown.Name Get end)

                // *** End programmer edit section *** (LookupDropdown.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (LookupDropdown.Name Set start)

                // *** End programmer edit section *** (LookupDropdown.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (LookupDropdown.Name Set end)

                // *** End programmer edit section *** (LookupDropdown.Name Set end)
            }
        }
        
        /// <summary>
        /// LookupDropdown.
        /// </summary>
        // *** Start programmer edit section *** (LookupDropdown.MasterLookupDropdown CustomAttributes)

        // *** End programmer edit section *** (LookupDropdown.MasterLookupDropdown CustomAttributes)
        [PropertyStorage(new string[] {
                "MasterLookupDropdown"})]
        [NotNull()]
        public virtual EmberFlexberryDummy.MasterLookupDropdown MasterLookupDropdown
        {
            get
            {
                // *** Start programmer edit section *** (LookupDropdown.MasterLookupDropdown Get start)

                // *** End programmer edit section *** (LookupDropdown.MasterLookupDropdown Get start)
                EmberFlexberryDummy.MasterLookupDropdown result = this.fMasterLookupDropdown;
                // *** Start programmer edit section *** (LookupDropdown.MasterLookupDropdown Get end)

                // *** End programmer edit section *** (LookupDropdown.MasterLookupDropdown Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (LookupDropdown.MasterLookupDropdown Set start)

                // *** End programmer edit section *** (LookupDropdown.MasterLookupDropdown Set start)
                this.fMasterLookupDropdown = value;
                // *** Start programmer edit section *** (LookupDropdown.MasterLookupDropdown Set end)

                // *** End programmer edit section *** (LookupDropdown.MasterLookupDropdown Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// Представление для проверки лукапа-дропдауна на форме редактирования.
            /// </summary>
            public static ICSSoft.STORMNET.View LookupDropdown
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("LookupDropdown", typeof(EmberFlexberryDummy.LookupDropdown));
                }
            }
        }
    }
}
