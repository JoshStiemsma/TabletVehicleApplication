// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class DataBackup
 
// {
//     public static VehicleStructure vehiclestructure = new VehicleStructure();
//     public static Batterypack batterypack = new Batterypack();
//     public static ElectricMotors electricMotors = new ElectricMotors();
//     public static Chasis chasis = new Chasis();
// }

// public class VehicleStructure
// {
//     public Lightweighting lightweighting = new Lightweighting(
//         "To extend vehicle range, electric vehicle body structures and components must be lightweight.",
//         "Wide variety of polymer-based materials for lightweight components. Structural adhesives that eliminate heavier mechanical fasteners. Solutions significantly reduce weight, carbon emissions and waste.",
//         "<b>Lightweight body parts and components</b> \nCRASTIN® \nKEVLAR® \nMULTIBASE® \nNOMEX® \nTEDLAR™ \nZYTEL® \n<b>Adhesives technology for vehicle bonding</b> \nBETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives \nBETASEAL™ glass bonding systems"
//         );
//     public Safety safety = new Safety(
//         "Ensure highest level of pedestrian and bicyclist safety through active safety systems and pre-impact solutions like pedestrian airbags, autonomous braking and steering.",
//         "Electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission, creep-resistant homopolymer gears and locking systems.",
//         "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nZYTEL® EF / FR  series\nZYTEL® HTN EF series"
//          );
//     public NVH nvh = new NVH(
//        "Ride experience is more important than ever as autonomous vehicles become work and social environments. Acoustical performance will be essential.",
//        "Portfolio of fiber materials, adhesives and lubricants that reduce squeaks, rattles, vibrations, wind and road noise.",
//        "BETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives \nBETASEAL™ glass bonding systems \nKEVLAR® vibration dampers \nMEGUM™, THIXON™, ROBOND™ rubber-to-substrate bonding agents \nMOLYKOTE™ lubricants\nMULTIBASE® anti-squeak additive"
//         );
//     public Durability durability = new Durability(
//        "Vehicle body structure must be durable and impact/crash resistant.",
//        "Impact-resistant materials for body components and crash-durable adhesives for bonding of vehicle structures.",
//        "<b>Impact and penetration resistant materials</b> \nKEVLAR® \nNOMEX® \n(Adhesives technology) \nBETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives"
//         );
//     public Sensing sensing = new Sensing(
//        "Accurate, upgradable and reliable data acquisition systems and electro-mechanical actuators will dictate powertrain electrification acceptance as well as autonomous driving.",
//        "Electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission and creep-resistant homopolymer gears and locking systems.",
//        "CRASTIN® HR/FR series \nDELRIN® 100/500 series \nZYTEL® EF/FR series \nZYTEL® LCPA series \nZYTEL® HTN EF series"
//         );
// }


// public class Batterypack
// {
//     public Lightweighting lightweighting = new Lightweighting(
//          "Battery packs add weight to electric vehicles, thus negatively impacting drive-range improvements.",
//          "Lightweight components and battery pack assembly innovation, including adhesives that eliminate heavier mechanical fasteners and allow joining of multiple types of substrates.",
//          "ZYTEL® (lightweight module housings and end plates) \nBETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives \nBETASEAL™ thermal-conductive adhesives and gap fillers"
//          );
//     public Safety safety = new Safety(
//         "Batteries create heat that must be managed for safety reasons and long service life.",
//         "Wide range of thermal-conductive, heat-resistant, electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers.",
//         "BETAFORCE™ thermal conductive adhesive\nBETASEAL™ thermal conductive gap filler \nBETAMATE™ structural adhesives\nCRASTIN® HR/FR series \nKAPTON® (uniform heating, high temperature resistance, electrical insulation – film) \nKEVLAR® XF (fire resistance/containment, cell-to-cell thermal management) \nNOMEX® XF (fire resistance/containment, cell-to-cell thermal management, arc protection) \nTEMPRION® (Thermally conductive films and gap filler) \nZYTEL® (Thermal and electrical conductivity) \nZYTEL® LCPA (hydrolysis, glycol and chemical resistance) \nZYTEL® EF/ FR series\nZYTEL® HTN EF series"
//          );
//     public NVH nvh = new NVH(
//       "Ride experience is more important than ever as autonomous vehicles become work and social environments. Acoustical performance will be essential.",
//       "Portfolio of fiber materials, adhesives and lubricants that reduce squeaks, rattles and vibrations.",
//       "BETAFORCE™ multi-material bonding adhesives\nBETAMATE™ structural adhesives\nBETASEAL™ glass bonding systems\nKEVLAR® vibration dampers\nMEGUM™, THIXON™, ROBOND™ rubber-to-substrate bonding agents\nMOLYKOTE™ lubricants\nMULTIBASE® anti-squeak additive"
//        );
//     public Durability durability = new Durability(
//        "Battery packs are the lifeblood of the vehicle. They must be durable and long-lasting.",
//        "Components and assembly solutions that create a more durable, long-lasting battery pack.",
//        "<b>Adhesives technology for stiffness, strength and corrosion protection</b>\nBETAFORCE™ multi-material bonding adhesives\nBETAMATE™ structural adhesives\nBETASEAL™ thermal conductive adhesives and gap fillers\nKEVLAR® (penetration resistance)"
//         );
//     public Sensing sensing = new Sensing(
//        "Batteries must perform under all possible scenarios as they are the heart of Hybrid Electric (HEVs, PHEVs), Battery Electric (BEVs) and Fuel Cell (FCV). Interconnects, sensors and electro-mechanical actuators must be dependable, accurate and upgradable.",
//        "Electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission, creep-resistant homopolymer gears and locking systems.",
//         "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nZYTEL® EF / FR series\nZYTEL® LCPA series\nZYTEL® HTN EF series"
//         );
// }

// public class ElectricMotors
// {
//     public Lightweighting lightweighting = new Lightweighting(
//          "Under-the-hood components are part of the vehicle weight reduction equation.",
//          "Lightweight polymer-based materials",
//          "<b>Electric motor components</b>\nCRASTIN® (FR-V0 at 0.8mm, non-halogen)\nZYTEL®\nZYTEL® HTN (FR-V0 at 0.8mm, non-halogen, thermal conductivity)"
//          );
//     public Safety safety = new Safety(
//         "Electric motors are more compact in design, which leads to high-heat environments that present potential heat and fire-related hazards. Components must be resistant and durable.",
//         "Wide range of heat-resistant, electrically-friendly, flame-retardant and halogen-free materials for high-voltage connectors, busbars and insulators.",
//         "CRASTIN® (heat-resistance, FR-V0 at 0.8mm, non-halogen)\nKAPTON® (slot & wire insulation)\nKEVLAR® XF (fire resistance)\nNOMEX® (electrical insulation/heat resistance)\nVAMAC® (halogen-free, low-smoke cable jacketing and insulation)\nZYTEL® (FR-V0 at 0.8mm, heat resistance)\nZYTEL® HTN (FR-V0 at 0.8mm, non-halogen)"
//          );
//     public NVH nvh = new NVH(
//        "Electric motors contain many components and moving parts creating the potential for noise and vibration. Without ICE(main noise source in traditional cars), BEV is facing new NVH requirements.",
//        "Lubricants and additives that reduce squeaks, rattles and vibrations.",
//        "MOLYKOTE™ lubricants (reduce squeaks, rattles, vibration)\nMULTIBASE® (anti-squeak additive)"
//         );
//     public Durability durability = new Durability(
//        "Electric motors need to last for the lifetime of the vehicle. Smooth operation and durable components are essential.",
//        "Lubricants and additives that enhance durability.",
//        "MOLYKOTE™ lubricants (friction, wear, corrosion protection)\nMULTIBASE® (anti-scratch additive)"
//         );
//     public Sensing sensing = new Sensing(
//        "Interconnects, sensors and electro-mechanical actuators must be dependable, accurate and upgradable.",
//        "Electrically-friendly, flame-retardant and halogen-free materials for connectors, bobbins, bus bars and power control units, as well as low-emission, creep-resistant homopolymer gears and locking systems.",
//        "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nZYTEL® EF / FR / NH series\nZYTEL® LCPA series\nZYTEL® HTN EF series"
//         );
// }

// public class Chasis
// {
//     // public Lightweighting lightweighting = new Lightweighting();

//     public Lightweighting lightweighting = new Lightweighting(
//          "Auto EE applications are part of the vehicle weight reduction equation.",
//          "Wide product range of thermally-conductive and heat-resistant performance materials to replace metal.",
//          "CRASTIN® (hydrolysis and heat resistance)\nZYTEL® HTN (thermal conductivity and hydrolysis)"
//          );
//     public Safety safety = new Safety(
//         "Thermal management and heat-related safety considerations are critical for the electrification and automation components that optimize powertrain and chassis operations in electric vehicles.",
//         "Wide range of thermal management, heat-resistant and flame-retardant materials.",
//         "BETACOOL™ (coolant system)\nCRASTIN® (EMI shielding for electronics, plus high-voltage resistance)\nKAPTON® (for cabin heater components)\nPCM (phase change material for latent heat storage)\nPI-based heater products\nVAMAC® (halogen-free, low-smoke cable jacketing and insulation)\nZYTEL® (for extruded coolant pipes)"
//          );
//     public NVH nvh = new NVH(
//        "Ride experience is more important than ever as autonomous vehicles become work and social environments. Acoustical performance will be essential.",
//        "Portfolio of specialty adhesives that reduce vibrational energy.",
//        "MEGUM™\nTHIXON™\nROBOND™\nrubber-to-substrate bonding agents (bonding component brackets and mounts)"
//         );
//     public Durability durability = new Durability(
//        "",
//        "",
//        ""
//         );
//     public Sensing sensing = new Sensing(
//        "Efficient, high-performance power control units and automated assists will be essential to vehicle electrification and autonomy. Interconnects, sensors and electro-mechanical actuators must be dependable, accurate and upgradable.",
//        "Control unit connector, sensor, semiconductor and circuit board advanced material technologies for safe and reliable vehicle connectivity and autonomous operation. This includes, electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission, creep-resistant homopolymer gears and locking systems.",
//        "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nPhoto resists;\nMEGAPOSIT™\nMICROPOSIT™\nPlating, substrates;\nCIRCUPOSIT™\nCONDUCTRON™\nDURAPOSIT™\nKAPTON™\nMICROFILL™\nPYRALUX™\nRISTON™\nPolishers, cleaners, conductive pastes\nZYTEL® EF / FR / NH series\nZYTEL® LCPA series\nZYTEL® HTN EF series"
//         );
// }

// public class Lightweighting
// {
//     public Lightweighting(string a, string b, string c)
//     {
//         data.Add(a);
//         data.Add(b);
//         data.Add(c);
//     }

//     public List<string> data = new List<string>();
//     public string[] data2 = new string[3];

// }
// public class Safety
// {
//     public List<string> data = new List<string>();
//     public Safety(string a, string b, string c)
//     {
//         data.Add(a);
//         data.Add(b);
//         data.Add(c);
//     }
// }
// public class NVH
// {
//     public List<string> data = new List<string>();
//     public NVH(string a, string b, string c)
//     {
//         data.Add(a);
//         data.Add(b);
//         data.Add(c);
//     }
// }
// public class Durability
// {
//     public List<string> data = new List<string>();
//     public Durability(string a, string b, string c)
//     {
//         data.Add(a);
//         data.Add(b);
//         data.Add(c);
//     }
// }
// public class Sensing
// {
//     public List<string> data = new List<string>();
//     public Sensing(string a, string b, string c)
//     {
//         data.Add(a);
//         data.Add(b);
//         data.Add(c);
//     }
// }
