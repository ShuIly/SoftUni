using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{

	class Head
	{
		public ulong EnergyConsumption { get; set; }
		public int IQ { get; set; }
		public string SkinMaterial { get; set; }

		public override string ToString()
		{
			string result = String.Format(
				"#Head:\r\n" +
				$"###Energy consumption: {EnergyConsumption}\r\n" +
				$"###IQ: {IQ}\r\n" +
				$"###Skin material: {SkinMaterial}"
			);

			return result;
		}
	}

	class Torso
	{
		public ulong EnergyConsumption { get; set; }
		public double ProcessorSize { get; set; }
		public string CorpusMaterial { get; set; }

		public override string ToString()
		{
			string result = String.Format(
				"#Torso:\r\n" +
				$"###Energy consumption: {EnergyConsumption}\r\n" +
				$"###Processor size: {ProcessorSize:F1}\r\n" +
				$"###Corpus material: {CorpusMaterial}"
			);

			return result;
		}
	}

	class Arm
	{
		public ulong EnergyConsumption { get; set; }
		public int Reach { get; set; }
		public int Fingers { get; set; }

		public override string ToString()
		{
			string result = String.Format(
				"#Arm:\r\n" +
				$"###Energy consumption: {EnergyConsumption}\r\n" +
				$"###Reach: {Reach}\r\n" +
				$"###Fingers: {Fingers}"
			);

			return result;
		}
	}

	class Leg
	{
		public ulong EnergyConsumption { get; set; }
		public int Strength { get; set; }
		public int Speed { get; set; }

		public override string ToString()
		{
			string result = String.Format(
				"#Leg:\r\n" +
				$"###Energy consumption: {EnergyConsumption}\r\n" +
				$"###Strength: {Strength}\r\n" +
				$"###Speed: {Speed}"
			);

			return result;
		}
	}

	class Robot
	{

		public ulong Energy { get; set; }
		public Head Head { get; set; }
		public Torso Torso { get; set; }
		public List<Arm> Arms { get; set; }
		public List<Leg> Legs { get; set; }

		public Robot()
		{
			Arms = new List<Arm>();
			Legs = new List<Leg>();
		}

		public void AddHead(ulong energyConsumption, int iq, string skinMaterial)
		{
			Head head = new Head()
			{
				EnergyConsumption = energyConsumption,
				IQ = iq,
				SkinMaterial = skinMaterial
			};

			if (Head == null || Head.EnergyConsumption > energyConsumption)
			{
				Head = head;
			}
		}

		public void AddTorso(ulong energyConsumption, double processorSize, string corpusMaterial)
		{
			Torso torso = new Torso()
			{
				EnergyConsumption = energyConsumption,
				ProcessorSize = processorSize,
				CorpusMaterial = corpusMaterial
			};

			if (Torso == null || Torso.EnergyConsumption > energyConsumption)
			{
				Torso = torso;
			}
		}

		public void AddArm(ulong energyConsumption, int reach, int fingers)
		{
			Arm arm = new Arm()
			{
				EnergyConsumption = energyConsumption,
				Reach = reach,
				Fingers = fingers
			};

			if (Arms.Count < 2)
			{
				Arms.Add(arm);
			}
			else if (Arms[0].EnergyConsumption > energyConsumption)
			{
				Arms[0] = arm;
			}
			else if (Arms[1].EnergyConsumption > energyConsumption)
			{
				Arms[1] = arm;
			}
		}

		public void AddLeg(ulong energyConsumption, int strength, int speed)
		{
			Leg arm = new Leg()
			{
				EnergyConsumption = energyConsumption,
				Strength = strength,
				Speed = speed
			};

			if (Legs.Count < 2)
			{
				Legs.Add(arm);
			}
			else if (Legs[0].EnergyConsumption > energyConsumption)
			{
				Legs[0] = arm;
			}
			else if (Legs[1].EnergyConsumption > energyConsumption)
			{
				Legs[1] = arm;
			}
		}

		public void AddPart(string partType, string val1, string val2, string val3)
		{
			switch (partType)
			{
				case "Head":
					AddHead(ulong.Parse(val1), int.Parse(val2), val3);
					break;
				case "Torso":
					AddTorso(ulong.Parse(val1), double.Parse(val2), val3);
					break;
				case "Arm":
					AddArm(ulong.Parse(val1), int.Parse(val2), int.Parse(val3));
					break;
				case "Leg":
					AddLeg(ulong.Parse(val1), int.Parse(val2), int.Parse(val3));
					break;
			}
		}

		public void PrintRobot()
		{

			if (Head == null || Torso == null || Legs.Count < 2 || Arms.Count < 2)
			{
				Console.WriteLine("We need more parts!");
				return;
			}
			else
			{
				ulong sumPartsEnergyConsumption = Head.EnergyConsumption + Torso.EnergyConsumption
					+ Legs[0].EnergyConsumption + Legs[1].EnergyConsumption + Arms[0].EnergyConsumption
					+ Arms[1].EnergyConsumption;

				if (sumPartsEnergyConsumption > Energy)
				{
					Console.WriteLine("We need more power!");
				}
				else
				{
					Console.WriteLine("Jarvis:");
					Console.WriteLine(Head);
					Console.WriteLine(Torso);
					Console.WriteLine(string.Join(Environment.NewLine, Arms
						.OrderBy(a => a.EnergyConsumption)));
					Console.WriteLine(string.Join(Environment.NewLine, Legs
						.OrderBy(l => l.EnergyConsumption)));
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Robot jarvis = new Robot();

			ulong energy = ulong.Parse(Console.ReadLine());
			jarvis.Energy = energy;

			string input = Console.ReadLine();

			while (input != "Assemble!")
			{
				string[] inputTokens = input.Split();
				jarvis.AddPart(inputTokens[0], inputTokens[1], inputTokens[2], inputTokens[3]);
				input = Console.ReadLine();
			}

			jarvis.PrintRobot();
		}
	}
}
