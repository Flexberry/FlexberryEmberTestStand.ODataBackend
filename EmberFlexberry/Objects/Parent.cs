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
    /// Parent.
    /// </summary>
    // *** Start programmer edit section *** (Parent CustomAttributes)

    // *** End programmer edit section *** (Parent CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("parentE", new string[] {
            "Name",
            "EMail",
            "Birthday"})]
    [View("parentL", new string[] {
            "Name",
            "EMail",
            "Birthday"})]
    public class Parent : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private string fEMail;
        
        private System.DateTime? fBirthday;
        
        // *** Start programmer edit section *** (Parent CustomMembers)

        // *** End programmer edit section *** (Parent CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Parent.Name CustomAttributes)

        // *** End programmer edit section *** (Parent.Name CustomAttributes)
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Parent.Name Get start)

                // *** End programmer edit section *** (Parent.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Parent.Name Get end)

                // *** End programmer edit section *** (Parent.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Parent.Name Set start)

                // *** End programmer edit section *** (Parent.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Parent.Name Set end)

                // *** End programmer edit section *** (Parent.Name Set end)
            }
        }
        
        /// <summary>
        /// EMail.
        /// </summary>
        // *** Start programmer edit section *** (Parent.EMail CustomAttributes)

        // *** End programmer edit section *** (Parent.EMail CustomAttributes)
        public virtual string EMail
        {
            get
            {
                // *** Start programmer edit section *** (Parent.EMail Get start)

                // *** End programmer edit section *** (Parent.EMail Get start)
                string result = this.fEMail;
                // *** Start programmer edit section *** (Parent.EMail Get end)

                // *** End programmer edit section *** (Parent.EMail Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Parent.EMail Set start)

                // *** End programmer edit section *** (Parent.EMail Set start)
                this.fEMail = value;
                // *** Start programmer edit section *** (Parent.EMail Set end)

                // *** End programmer edit section *** (Parent.EMail Set end)
            }
        }
        
        /// <summary>
        /// Birthday.
        /// </summary>
        // *** Start programmer edit section *** (Parent.Birthday CustomAttributes)

        // *** End programmer edit section *** (Parent.Birthday CustomAttributes)
        public virtual System.DateTime? Birthday
        {
            get
            {
                // *** Start programmer edit section *** (Parent.Birthday Get start)

                // *** End programmer edit section *** (Parent.Birthday Get start)
                System.DateTime? result = this.fBirthday;
                // *** Start programmer edit section *** (Parent.Birthday Get end)

                // *** End programmer edit section *** (Parent.Birthday Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Parent.Birthday Set start)

                // *** End programmer edit section *** (Parent.Birthday Set start)
                this.fBirthday = value;
                // *** Start programmer edit section *** (Parent.Birthday Set end)

                // *** End programmer edit section *** (Parent.Birthday Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "parentE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View parentE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("parentE", typeof(EmberFlexberryDummy.Parent));
                }
            }
            
            /// <summary>
            /// "parentL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View parentL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("parentL", typeof(EmberFlexberryDummy.Parent));
                }
            }
        }
    }
}
