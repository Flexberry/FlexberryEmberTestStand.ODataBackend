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
    /// Sotrudnik.
    /// </summary>
    // *** Start programmer edit section *** (Sotrudnik CustomAttributes)

    // *** End programmer edit section *** (Sotrudnik CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("SotrudnikE", new string[] {
            "Familiia as \'Фамилия\'",
            "Name as \'Имя\'",
            "DataRozhdeniia as \'Дата\'",
            "Departament as \'Департамент\'",
            "Departament.vid as \'Вид департамента\'"})]
    [MasterViewDefineAttribute("SotrudnikE", "Departament", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "name")]
    [View("SotrudnikL", new string[] {
            "Familiia as \'Фамилия\'",
            "Name as \'Имя\'",
            "DataRozhdeniia as \'Дата\'"})]
    public class Sotrudnik : ICSSoft.STORMNET.DataObject
    {
        
        private string fFamiliia;
        
        private string fName;
        
        private System.DateTime fDataRozhdeniia;
        
        private EmberFlexberryDummy.Departament fDepartament;

        // *** Start programmer edit section *** (Sotrudnik CustomMembers)

        // *** End programmer edit section *** (Sotrudnik CustomMembers)


        /// <summary>
        /// Familiia.
        /// </summary>
        // *** Start programmer edit section *** (Sotrudnik.Familiia CustomAttributes)

        // *** End programmer edit section *** (Sotrudnik.Familiia CustomAttributes)
        public virtual string Familiia
        {
            get
            {
                // *** Start programmer edit section *** (Sotrudnik.Familiia Get start)

                // *** End programmer edit section *** (Sotrudnik.Familiia Get start)
                string result = this.fFamiliia;
                // *** Start programmer edit section *** (Sotrudnik.Familiia Get end)

                // *** End programmer edit section *** (Sotrudnik.Familiia Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Sotrudnik.Familiia Set start)

                // *** End programmer edit section *** (Sotrudnik.Familiia Set start)
                this.fFamiliia = value;
                // *** Start programmer edit section *** (Sotrudnik.Familiia Set end)

                // *** End programmer edit section *** (Sotrudnik.Familiia Set end)
            }
        }

        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Sotrudnik.Name CustomAttributes)

        // *** End programmer edit section *** (Sotrudnik.Name CustomAttributes)
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Sotrudnik.Name Get start)

                // *** End programmer edit section *** (Sotrudnik.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Sotrudnik.Name Get end)

                // *** End programmer edit section *** (Sotrudnik.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Sotrudnik.Name Set start)

                // *** End programmer edit section *** (Sotrudnik.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Sotrudnik.Name Set end)

                // *** End programmer edit section *** (Sotrudnik.Name Set end)
            }
        }

        /// <summary>
        /// DataRozhdeniia.
        /// </summary>
        // *** Start programmer edit section *** (Sotrudnik.DataRozhdeniia CustomAttributes)

        // *** End programmer edit section *** (Sotrudnik.DataRozhdeniia CustomAttributes)
        public virtual System.DateTime DataRozhdeniia
        {
            get
            {
                // *** Start programmer edit section *** (Sotrudnik.DataRozhdeniia Get start)

                // *** End programmer edit section *** (Sotrudnik.DataRozhdeniia Get start)
                System.DateTime result = this.fDataRozhdeniia;
                // *** Start programmer edit section *** (Sotrudnik.dataRozhdeniia Get end)

                // *** End programmer edit section *** (Sotrudnik.dataRozhdeniia Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Sotrudnik.DataRozhdeniia Set start)

                // *** End programmer edit section *** (Sotrudnik.DataRozhdeniia Set start)
                this.fDataRozhdeniia = value;
                // *** Start programmer edit section *** (Sotrudnik.DataRozhdeniia Set end)

                // *** End programmer edit section *** (Sotrudnik.DataRozhdeniia Set end)
            }
        }
        
        /// <summary>
        /// Sotrudnik.
        /// </summary>
        // *** Start programmer edit section *** (Sotrudnik.Departament CustomAttributes)

        // *** End programmer edit section *** (Sotrudnik.Departament CustomAttributes)
        [PropertyStorage(new string[] {
                "Departament"})]
        [NotNull()]
        public virtual EmberFlexberryDummy.Departament Departament
        {
            get
            {
                // *** Start programmer edit section *** (Sotrudnik.Departament Get start)

                // *** End programmer edit section *** (Sotrudnik.Departament Get start)
                EmberFlexberryDummy.Departament result = this.fDepartament;
                // *** Start programmer edit section *** (Sotrudnik.Departament Get end)

                // *** End programmer edit section *** (Sotrudnik.Departament Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Sotrudnik.Departament Set start)

                // *** End programmer edit section *** (Sotrudnik.Departament Set start)
                this.fDepartament = value;
                // *** Start programmer edit section *** (Sotrudnik.Departament Set end)

                // *** End programmer edit section *** (Sotrudnik.Departament Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "SotrudnikE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SotrudnikE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SotrudnikE", typeof(EmberFlexberryDummy.Sotrudnik));
                }
            }
            
            /// <summary>
            /// "SotrudnikL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SotrudnikL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SotrudnikL", typeof(EmberFlexberryDummy.Sotrudnik));
                }
            }
        }
    }
}
