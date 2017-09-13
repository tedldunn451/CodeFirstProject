using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject.Domain
{
    public class PlayerCharacter
    {
		public string CharacterName { get; set; }
		public int CharacterLevel { get; set; }
		public int ExperiencePoints { get; set; }
		public int HitPoints { get; set; }

		enum Race { Human, Dwarf, Elf, Halfling};
		enum CharacterClass { Fighter, Wizard, Thief, Cleric};
	}
}
