using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace ViewModels.Models
{
    public class AddressToAddVM
    {
        public Address address { get; set; }
        public List<SelectListItem> states { get; set; }

        public void CreateStateList()
        {
            List<State> listOfStates = new List<State>
            {
                new State() {Name = "Arkansas", Abbreviation = "AR"},
                new State() {Name = "Kansas", Abbreviation = "KS" },
                new State() {Name = "Illinois", Abbreviation = "IL" },
                new State() {Name = "Texas", Abbreviation = "TX" },
                new State() {Name = "Washington", Abbreviation = "WA"}
            };

            states = new List<SelectListItem>();

            foreach (State state in listOfStates)
            {
                SelectListItem newItem = new SelectListItem();

                newItem.Text = state.Abbreviation;
                newItem.Value = state.Name;

                states.Add(newItem);
            }
        }
    }
}