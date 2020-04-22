using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IModeOfPaymentConnector : IConnector
	{
		Sort.Order? SortOrder { get; set; }
		Sort.By.ModeOfPayment? SortBy { get; set; }

        [SearchParameter("filter")]
		Filter.ModeOfPayment? FilterBy { get; set; }


        [SearchParameter]
		string Code { get; set; }
		ModeOfPayment Update(ModeOfPayment modeOfPayment);

		ModeOfPayment Create(ModeOfPayment modeOfPayment);

		ModeOfPayment Get(string id);

		void Delete(string id);

		EntityCollection<ModeOfPayment> Find();

	}
}
