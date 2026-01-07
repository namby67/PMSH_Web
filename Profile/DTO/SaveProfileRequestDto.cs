namespace Profile.DTO
{
    public class SaveProfileRequestDto
    {
        public int Type { get; set; }

        // -------- Individual --------
        public string CodeIndividual { get; set; }
        public string AccountIndividual { get; set; }
        public string LastNameIndivdual { get; set; }
        public string FirstNameIndividual { get; set; }
        public string MiddleNameIndividual { get; set; }
        public int LanguageIndividual { get; set; }
        public int TitleIndividual { get; set; }
        public string AddressIndividual { get; set; }
        public string BusAddressIndividual { get; set; }
        public string CityIndividual { get; set; }
        public string PostalIndividual { get; set; }
        public int CountryIndividual { get; set; }
        public int StateIndividual { get; set; }
        public string SalutationIndividual { get; set; }
        public int VIPIndividual { get; set; }
        public string ReasonIndividual { get; set; }
        public string PassportIndividual { get; set; }
        public string KeywordIndividual { get; set; }
        public DateTime DobIndividual { get; set; }
        public int NationalityIndividual { get; set; }
        public string TelephoneIndividual { get; set; }
        public string EmailIndividual { get; set; }
        public string WebsiteIndividual { get; set; }
        public string HandPhoneIndividual { get; set; }
        public bool ActiveIndividual { get; set; }
        public bool ContactIndividual { get; set; }
        public string TaxIndividual { get; set; }
        public bool BlackListIndividual { get; set; }
        public string BlackListReasonIndividual { get; set; }
        public string CardIndividual { get; set; }
        public string CompanyIndividual { get; set; }
        public string Company2Individual { get; set; }
        public string BusinessTitleIndividual { get; set; }
        public string OtherIndividual { get; set; }
        public string ReligionIndividual { get; set; }
        public string NationIndividual { get; set; }
        public string PurposeIndividual { get; set; }

        // -------- Company / Organization --------
        public string CodeCOM { get; set; }
        public string AccountCOM { get; set; }
        public string FullAccount { get; set; }
        public string AddressCOM { get; set; }
        public string BusAddressCOM { get; set; }
        public string CityCOM { get; set; }
        public string PostalCOM { get; set; }
        public int CountryCOM { get; set; }
        public int StateCOM { get; set; }
        public string KeywordCOM { get; set; }
        public string NoteCOM { get; set; }
        public string TelephoneCOM { get; set; }
        public string EmailCOM { get; set; }
        public string WebsiteCOM { get; set; }
        public string HandPhoneCOM { get; set; }
        public bool ActiveCOM { get; set; }
        public string ARCOM { get; set; }
        public int OwnerCOM { get; set; }
        public int TerritoryCOM { get; set; }
        public int SaleInChargeCOM { get; set; }
        public string ContactNameCOM { get; set; }
        public string CurrencyCOM { get; set; }
        public string TaxCOM { get; set; }
        public string CompanyTypeCOM { get; set; }
        public bool BlackListCOM { get; set; }
        public string BlackListReasonCOM { get; set; }
        public string Company2COM { get; set; }
        public string BusinessTitleCOM { get; set; }
        public int MarketCOM { get; set; }

        // -------- Group --------
        public string CodeGroup { get; set; }
        public string GroupNameGroup { get; set; }
        public int LanguageGruop { get; set; }
        public string AddressGroup { get; set; }
        public string HomeAddressGroup { get; set; }
        public string CityGroup { get; set; }
        public string PostalGroup { get; set; }
        public int CountryGroup { get; set; }
        public int StateGroup { get; set; }
        public int VIPGroup { get; set; }
        public string VIPReasonGroup { get; set; }
        public string NotesGroup { get; set; }
        public string TelephoneGroup { get; set; }
        public string FaxGroup { get; set; }
        public string EmailGroup { get; set; }
        public string WebsiteGroup { get; set; }
        public string HandPhoneGroup { get; set; }
        public bool HistoryGroup { get; set; }
        public string AcctContact { get; set; }
        public string CurrencyGroup { get; set; }

        // -------- Contact --------
        public string CodeContact { get; set; }
        public string AccountContact { get; set; }
        public string LastNameContact { get; set; }
        public string FirstNameContact { get; set; }
        public string MiddleNameContact { get; set; }
        public int LanguageContact { get; set; }
        public int TitleContact { get; set; }
        public string AddressContact { get; set; }
        public string HomeAddressContact { get; set; }
        public string CityContact { get; set; }
        public string PostalContact { get; set; }
        public int CountryContact { get; set; }
        public int StateContact { get; set; }
        public string SalutationContact { get; set; }
        public DateTime DobContact { get; set; }
        public string TelephoneContact { get; set; }
        public string FaxContact { get; set; }
        public string EmaiContact { get; set; }
        public string WebsiteContact { get; set; }
        public string HandPhoneContact { get; set; }
        public string PositionContact { get; set; }
        public string DeptContact { get; set; }
        public int OwnerContact { get; set; }
        public int TerritoryContact { get; set; }
    }
    public class ValidationErrorDto
    {
        public string Field { get; set; }
        public string Message { get; set; }
    }
}
