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
    /// VidDepartamenta.
    /// </summary>
    // *** Start programmer edit section *** (VidDepartamenta CustomAttributes)

    // *** End programmer edit section *** (VidDepartamenta CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("VidDepartamentaE", new string[] {
            "Name as \'Название\'"})]
    [View("VidDepartamentaL", new string[] {
            "Name as \'Название\'"})]
    public class VidDepartamenta : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        // *** Start programmer edit section *** (VidDepartamenta CustomMembers)

        // *** End programmer edit section *** (VidDepartamenta CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (VidDepartamenta.Name CustomAttributes)

        // *** End programmer edit section *** (VidDepartamenta.Name CustomAttributes)
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (VidDepartamenta.Name Get start)

                // *** End programmer edit section *** (VidDepartamenta.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (VidDepartamenta.Name Get end)

                // *** End programmer edit section *** (VidDepartamenta.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (VidDepartamenta.Name Set start)

                // *** End programmer edit section *** (VidDepartamenta.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (VidDepartamenta.Name Set end)

                // *** End programmer edit section *** (VidDepartamenta.Name Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "VidDepartamentaE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View VidDepartamentaE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("VidDepartamentaE", typeof(EmberFlexberryDummy.VidDepartamenta));
                }
            }
            
            /// <summary>
            /// "VidDepartamentaL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View VidDepartamentaL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("VidDepartamentaL", typeof(EmberFlexberryDummy.VidDepartamenta));
                }
            }
        }
    }
}
