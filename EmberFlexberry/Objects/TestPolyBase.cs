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
    /// TestPolyBase.
    /// </summary>
    // *** Start programmer edit section *** (TestPolyBase CustomAttributes)

    // *** End programmer edit section *** (TestPolyBase CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class TestPolyBase : ICSSoft.STORMNET.DataObject
    {
        
        private string fPole;
        
        // *** Start programmer edit section *** (TestPolyBase CustomMembers)

        // *** End programmer edit section *** (TestPolyBase CustomMembers)

        
        /// <summary>
        /// Pole.
        /// </summary>
        // *** Start programmer edit section *** (TestPolyBase.Pole CustomAttributes)

        // *** End programmer edit section *** (TestPolyBase.Pole CustomAttributes)
        public virtual string Pole
        {
            get
            {
                // *** Start programmer edit section *** (TestPolyBase.Pole Get start)

                // *** End programmer edit section *** (TestPolyBase.Pole Get start)
                string result = this.fPole;
                // *** Start programmer edit section *** (TestPolyBase.Pole Get end)

                // *** End programmer edit section *** (TestPolyBase.Pole Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TestPolyBase.Pole Set start)

                // *** End programmer edit section *** (TestPolyBase.Pole Set start)
                this.fPole = value;
                // *** Start programmer edit section *** (TestPolyBase.Pole Set end)

                // *** End programmer edit section *** (TestPolyBase.Pole Set end)
            }
        }
    }
}