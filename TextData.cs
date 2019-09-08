using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextData 
{
    public static VehicleStructure vehiclestructure = new VehicleStructure();
    public static Batterypack batterypack = new Batterypack();
    public static ElectricMotors electricMotors = new ElectricMotors();
    public static Chasis chasis = new Chasis();
}

// public class VehicleStructure
// {
//     public Lightweighting lightweighting = new Lightweighting(
//         "为了提高电动汽车的续航里程，车身结构及零部件必须实现轻量化。",
//         "通过使用各种聚合物材料生产轻质零部件，同时采用结构胶替代更重的机械紧固件，可以显著减轻车重，以达到节能减排的目的。",
//         "<b>轻量化车身及零部件</b> \nCRASTIN® \nKEVLAR® \nMULTIBASE® \nNOMEX® \nTEDLAR™ \nZYTEL® \n<b>汽车粘合剂技术</b> \nBETAFORCE™ 复合材料结构胶 \nBETAMATE™ 结构粘合剂 \nBETASEAL™ 玻璃粘合系统"
//         );
//     public Safety safety = new Safety(
//         "采用主动式安全系统和行人安全气囊、自动制动系统及自动转向系统等防碰撞解决方案，最大程度确保行人和骑行者安全。",
//         "电气友好型无卤阻燃材料，可用于生产连接器、配电箱、线缆、电子控制器，以及低排放、抗蠕变均聚物齿轮和门锁系统。",
//         "CRASTIN® HR / FR 系列\nDELRIN® 100/500 系列\nZYTEL® EF / FR  系列\nZYTEL® HTN EF 系列"
//          );
//     public NVH nvh = new NVH(
//        "随着无人驾驶汽车的日趋成熟，乘客体验变得日益重要，而车辆的声学性能也将变得至关重要。",
//        "广泛的纤维材料、粘合剂和润滑剂产品组合可减弱汽车异响、震动、风声及道路噪音。",
//        "BETAFORCE™ 复合材料结构胶 \nBETAMATE™ 结构粘合剂 \nBETASEAL™ 玻璃粘合系统 \nKEVLAR® 减震器 \nMEGUM™, THIXON™, ROBOND™ 粘合剂（用于橡胶与基材的粘合） \nMOLYKOTE™ 润滑剂\nMULTIBASE® 消声添加剂 "
//         );
//     public Durability durability = new Durability(
//        "车身结构必须坚固耐用，并具备抗冲击、抗碰撞性能。",
//        "应用于车身零部件的抗冲击材料，以及应用于汽车结构粘合的耐冲撞结构胶。",
//        "<b>抗冲击、抗刺穿材料</b> \nKEVLAR® \nNOMEX® \n(粘合剂技术) \nBETAFORCE™ 复合材料结构胶 \nBETAMATE™ 结构粘合剂"
//         );
//     public Sensing sensing = new Sensing(
//        "精准可靠、可升级的数据采集系统和机电作动器将决定动力系统电气化的可接受度和无人驾驶技术的发展。",
//        "电气友好型无卤阻燃材料，可用于生产连接器、配电箱、线缆、电子控制器，以及低排放、抗蠕变均聚物齿轮和锁定系统。",
//        "CRASTIN® HR/FR 系列 \nDELRIN® 100/500 系列 \nZYTEL® EF/FR 系列 \nZYTEL® LCPA 系列 \nZYTEL® HTN EF 系列"
//         );
// }


// public class Batterypack
// {
//     public Lightweighting lightweighting = new Lightweighting(
//          "电池组会增加车重，影响电动汽车的续航里程。",
//          "轻量化部件和电池组外壳粘接技术创新，包括可替代更重的机械紧固件并且可粘接各类基材的汽车粘合剂。 ",
//          "ZYTEL® (轻量化组件外壳和端板) \nBETAFORCE™ 复合材料结构胶 \nBETAMATE™ 结构粘合剂 \nBETASEAL™ 导热胶和填缝剂"
//          );
//     public Safety safety = new Safety(
//         "为了确保安全性并延长电池使用寿命，必须对电池产生的热量进行有效管理。",
//         "各种耐热阻燃的电气友好型无卤导热材料，可用于生产连接器、配电箱、线缆和电子控制器等部件。",
//         "BETAFORCE™ 导热胶\nBETASEAL™ 导热填缝剂 \nBETAMATE™ 结构胶\nCRASTIN® HR/FR 系列 \nKAPTON® (升温均匀、耐高温、电绝缘性好) \nNOMEX® XF (防火性、电芯间隔热) \nNOMEX® (电气绝缘、防电弧) \nTEMPRION® (导热导电性) \nZYTEL® (Thermal and electrical conductivity) \nZYTEL® LCPA (耐水解性、耐乙二醇性和耐化学性) \nZYTEL® EF/ FR 系列\nZYTEL® HTN EF 系列"
//          );
//     public NVH nvh = new NVH(
//       "随着无人驾驶汽车的日趋成熟，乘客体验变得日益重要，而车辆的声学性能也将变得至关重要。",
//       "广泛的纤维材料、粘合剂和润滑剂产品组合可减弱汽车异响、震动、风声及道路噪音。",
//       "BETAFORCE™ 复合材料结构胶\nBETAMATE™ 结构粘合剂\nBETASEAL™ 玻璃粘合系统\nKEVLAR® 减震器\nMEGUM™, THIXON™, ROBOND™ 粘合剂（用于橡胶与基材的粘合）\nMOLYKOTE™ 润滑剂\nMULTIBASE® 消声添加剂"
//        );
//     public Durability durability = new Durability(
//        "电池组是电动汽车的命脉，必须持久耐用。",
//        "动力总成解决方案可以使电池组更加持久耐用。",
//        "<b>可提升硬度、强度和防腐蚀保护的胶粘剂技术</b>\nBETAFORCE™ 复合材料结构胶\nBETAMATE™ 结构胶\nBETASEAL™ 导热胶和填缝剂\nKEVLAR® (抗刺穿性)"
//         );
//     public Sensing sensing = new Sensing(
//        "电池是混合动力汽车、纯电动汽车或燃料电池汽车的心脏，在任何情况下都必须正常运作。互联线、传感器和机电作动器必须可靠、精准、可升级。",
//        "电气友好型无卤阻燃材料，可用于生产连接器、配电箱、线缆、电子控制器，以及低排放、抗蠕变均聚物齿轮和锁定系统。",
//         "CRASTIN® HR / FR 系列\nDELRIN® 100/500 系列\nZYTEL® EF / FR 系列\nZYTEL® LCPA 系列\nZYTEL® HTN EF 系列"
//         );
// }

// public class ElectricMotors
// {
//     public Lightweighting lightweighting = new Lightweighting(
//          "如何减轻引擎盖下零部件的重量，是汽车轻量化面临的挑战之一。",
//          "轻质聚合物材料",
//          "<b>驱动电动机组件</b>\nCRASTIN® (0.8毫米阻燃等级为UL-94 V0，无卤)\nZYTEL®\nZYTEL® HTN (0.8毫米阻燃等级为UL-94 V0，无卤，导热性)"
//          );
//     public Safety safety = new Safety(
//         "驱动电机结构由于设计紧凑，会产生大量的热量，存在过热及燃烧风险。因此，电动机组件必须持久耐用。",
//         "各种耐热阻燃的电气友好型无卤材料，可用于高压连接器、汇流排和绝缘件等部件。",
//         "CRASTIN® (耐热性、0.8毫米阻燃等级为UL-94 V0，无卤)\nKAPTON® (电机槽绝缘和导线绝缘)\nKEVLAR® XF (防火性)\nNOMEX® (电绝缘性/耐热性)\nVAMAC® (低烟无卤电缆护套与绝缘)\nZYTEL® (0.8毫米阻燃等级为UL-94 V0，耐热性)\nZYTEL® HTN (0.8毫米阻燃等级为UL-94 V0，无卤)"
//          );
//     public NVH nvh = new NVH(
//        "驱动电机包含许多组件和活动部件，很容易产生噪音和震动。虽然没有内燃机引擎（传统汽车的主要噪音来源），但纯电动汽车面临着新的降噪缓振的需求。",
//        "丰富的润滑剂与添加剂产品可减弱汽车异响和震动。",
//        "MOLYKOTE™ 润滑剂（可减弱汽车异响和震动\nMULTIBASE® (消声添加剂)"
//         );
//     public Durability durability = new Durability(
//        "驱动电机的寿命应该超过整车使用寿命。运行顺畅、持久耐用的组件至关重要。",
//        "丰富的润滑剂与添加剂产品可提高部件耐久性。",
//        "MOLYKOTE™ 润滑剂（抗摩擦、耐磨损和防腐蚀）\nMULTIBASE® （耐刮擦添加剂）"
//         );
//     public Sensing sensing = new Sensing(
//        "互联线、传感器和机电作动器必须可靠、精准、可升级。",
//        "阻燃性电气友好型无卤材料，可用于生产连接器、绕线筒、汇流排、动力控制单元，以及低排放、抗蠕变均聚物齿轮和锁定系统。",
//        "CRASTIN® HR / FR 系列\nDELRIN® 100/500 系列\nZYTEL® EF / FR / NH 系列\nZYTEL® LCPA 系列\nZYTEL® HTN EF 系列"
//         );
// }

// public class Chasis
// {
//     // public Lightweighting lightweighting = new Lightweighting();

//     public Lightweighting lightweighting = new Lightweighting(
//          "如何减轻电子电气系统的重量，是汽车轻量化面临的挑战之一。",
//          "采用各种导热、耐热的高性能材料取代金属材料。",
//          "CRASTIN® (耐水解性和耐热性)\nZYTEL® HTN (导热性和耐水解性)"
//          );
//     public Safety safety = new Safety(
//         "电动汽车的电气化、自动化零部件的热管理以及与热相关的安全考量，对优化电动汽车动力总成系统和底盘的运行至关重要。 ",
//         "各类用于热管理的耐热阻燃材料。",
//         "BETACOOL™ (冷却剂系统)\nCRASTIN® (屏蔽电磁干扰，耐高压)\nKAPTON® (用于车厢加热器元件)\nPCM (用于潜热储存的相变材料)\n聚酰亚胺加热元件产品\nVAMAC® (无卤，低烟电缆护套与绝缘)\nZYTEL® (用于冷却剂管的挤出工艺)"
//          );
//     public NVH nvh = new NVH(
//        "随着无人驾驶汽车的日趋成熟，乘客体验变得日益重要，而车辆的声学性能也将变得至关重要。",
//        "减震专用汽车粘合剂产品组合。",
//        "MEGUM™\nTHIXON™\nROBOND™\n粘合剂（用于橡胶与基材的粘合，粘合部件支架和底座）"
//         );
//     public Durability durability = new Durability(
//        "",
//        "",
//        ""
//         );
//     public Sensing sensing = new Sensing(
//        "高效、高性能的动力控制单元和自动辅助系统对于汽车电气化与无人驾驶技术而言至关重要。互联线、传感器和机电作动器必须可靠、精准、可升级。",
//        "针对控制单元连接器、传感器、半导体和电路板的先进材料技术能够确保车联网和无人驾驶安全可靠，其中包括用于生产连接器、配电箱、线缆、电子控制器的电气友好型无卤阻燃材料，以及低排放、抗蠕变均聚物齿轮和锁定系统。",
//        "CRASTIN® HR / FR 系列\nDELRIN® 100/500 系列\n光刻胶\nMEGAPOSIT™\nMICROPOSIT™\n镀层、基材\nCIRCUPOSIT™\nCONDUCTRON™\nDURAPOSIT™\nKAPTON™\nMICROFILL™\nPYRALUX™\nRISTON™\n抛光剂、清洁剂和导电浆料\nZYTEL® EF / FR / NH 系列\nZYTEL® LCPA 系列\nZYTEL® HTN EF 系列"
//         );
// }

public class VehicleStructure
{
    public Lightweighting lightweighting = new Lightweighting(
        "To extend vehicle range, electric vehicle body structures and components must be lightweight.",
        "Wide variety of polymer-based materials for lightweight components. Structural adhesives that eliminate heavier mechanical fasteners. Solutions significantly reduce weight, carbon emissions and waste.",
        "<b>Lightweight body parts and components</b> \nCRASTIN® \nKEVLAR® \nMULTIBASE® \nNOMEX® \nTEDLAR™ \nZYTEL® \n<b>Adhesives technology for vehicle bonding</b> \nBETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives \nBETASEAL™ glass bonding systems"
        );
    public Safety safety = new Safety(
        "Ensure highest level of pedestrian and bicyclist safety through active safety systems and pre-impact solutions like pedestrian airbags, autonomous braking and steering.",
        "Electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission, creep-resistant homopolymer gears and locking systems.",
        "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nZYTEL® EF / FR  series\nZYTEL® HTN EF series"
         );
    public NVH nvh = new NVH(
       "Ride experience is more important than ever as autonomous vehicles become work and social environments. Acoustical performance will be essential.",
       "Portfolio of fiber materials, adhesives and lubricants that reduce squeaks, rattles, vibrations, wind and road noise.",
       "BETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives \nBETASEAL™ glass bonding systems \nKEVLAR® vibration dampers \nMEGUM™, THIXON™, ROBOND™ rubber-to-substrate bonding agents \nMOLYKOTE™ lubricants\nMULTIBASE® anti-squeak additive"
        );
    public Durability durability = new Durability(
       "Vehicle body structure must be durable and impact/crash resistant.",
       "Impact-resistant materials for body components and crash-durable adhesives for bonding of vehicle structures.",
       "<b>Impact and penetration resistant materials</b> \nKEVLAR® \nNOMEX® \n(Adhesives technology) \nBETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives"
        );
    public Sensing sensing = new Sensing(
       "Accurate, upgradable and reliable data acquisition systems and electro-mechanical actuators will dictate powertrain electrification acceptance as well as autonomous driving.",
       "Electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission and creep-resistant homopolymer gears and locking systems.",
       "CRASTIN® HR/FR series \nDELRIN® 100/500 series \nZYTEL® EF/FR series \nZYTEL® LCPA series \nZYTEL® HTN EF series"
        );
}


public class Batterypack
{
    public Lightweighting lightweighting = new Lightweighting(
         "Battery packs add weight to electric vehicles, thus negatively impacting drive-range improvements.",
         "Lightweight components and battery pack assembly innovation, including adhesives that eliminate heavier mechanical fasteners and allow joining of multiple types of substrates.",
         "ZYTEL® (lightweight module housings and end plates) \nBETAFORCE™ multi-material bonding adhesives \nBETAMATE™ structural adhesives \nBETASEAL™ thermal-conductive adhesives and gap fillers"
         );
    public Safety safety = new Safety(
        "Batteries create heat that must be managed for safety reasons and long service life.",
        "Wide range of thermal-conductive, heat-resistant, electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers.",
        "BETAFORCE™ thermal conductive adhesive\nBETASEAL™ thermal conductive gap filler \nBETAMATE™ structural adhesives\nCRASTIN® HR/FR series \nKAPTON® (uniform heating, high temperature resistance, electrical insulation – film) \nKEVLAR® XF (fire resistance/containment, cell-to-cell thermal management) \nNOMEX® XF (fire resistance/containment, cell-to-cell thermal management, arc protection) \nTEMPRION® (Thermally conductive films and gap filler) \nZYTEL® (Thermal and electrical conductivity) \nZYTEL® LCPA (hydrolysis, glycol and chemical resistance) \nZYTEL® EF/ FR series\nZYTEL® HTN EF series"
         );
    public NVH nvh = new NVH(
      "Ride experience is more important than ever as autonomous vehicles become work and social environments. Acoustical performance will be essential.",
      "Portfolio of fiber materials, adhesives and lubricants that reduce squeaks, rattles and vibrations.",
      "BETAFORCE™ multi-material bonding adhesives\nBETAMATE™ structural adhesives\nBETASEAL™ glass bonding systems\nKEVLAR® vibration dampers\nMEGUM™, THIXON™, ROBOND™ rubber-to-substrate bonding agents\nMOLYKOTE™ lubricants\nMULTIBASE® anti-squeak additive"
       );
    public Durability durability = new Durability(
       "Battery packs are the lifeblood of the vehicle. They must be durable and long-lasting.",
       "Components and assembly solutions that create a more durable, long-lasting battery pack.",
       "<b>Adhesives technology for stiffness, strength and corrosion protection</b>\nBETAFORCE™ multi-material bonding adhesives\nBETAMATE™ structural adhesives\nBETASEAL™ thermal conductive adhesives and gap fillers\nKEVLAR® (penetration resistance)"
        );
    public Sensing sensing = new Sensing(
       "Batteries must perform under all possible scenarios as they are the heart of Hybrid Electric (HEVs, PHEVs), Battery Electric (BEVs) and Fuel Cell (FCV). Interconnects, sensors and electro-mechanical actuators must be dependable, accurate and upgradable.",
       "Electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission, creep-resistant homopolymer gears and locking systems.",
        "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nZYTEL® EF / FR series\nZYTEL® LCPA series\nZYTEL® HTN EF series"
        );
}

public class ElectricMotors
{
    public Lightweighting lightweighting = new Lightweighting(
         "Under-the-hood components are part of the vehicle weight reduction equation.",
         "Lightweight polymer-based materials",
         "<b>Electric motor components</b>\nCRASTIN® (FR-V0 at 0.8mm, non-halogen)\nZYTEL®\nZYTEL® HTN (FR-V0 at 0.8mm, non-halogen, thermal conductivity)"
         );
    public Safety safety = new Safety(
        "Electric motors are more compact in design, which leads to high-heat environments that present potential heat and fire-related hazards. Components must be resistant and durable.",
        "Wide range of heat-resistant, electrically-friendly, flame-retardant and halogen-free materials for high-voltage connectors, busbars and insulators.",
        "CRASTIN® (heat-resistance, FR-V0 at 0.8mm, non-halogen)\nKAPTON® (slot & wire insulation)\nKEVLAR® XF (fire resistance)\nNOMEX® (electrical insulation/heat resistance)\nVAMAC® (halogen-free, low-smoke cable jacketing and insulation)\nZYTEL® (FR-V0 at 0.8mm, heat resistance)\nZYTEL® HTN (FR-V0 at 0.8mm, non-halogen)"
         );
    public NVH nvh = new NVH(
       "Electric motors contain many components and moving parts creating the potential for noise and vibration. Without ICE(main noise source in traditional cars), BEV is facing new NVH requirements.",
       "Lubricants and additives that reduce squeaks, rattles and vibrations.",
       "MOLYKOTE™ lubricants (reduce squeaks, rattles, vibration)\nMULTIBASE® (anti-squeak additive)"
        );
    public Durability durability = new Durability(
       "Electric motors need to last for the lifetime of the vehicle. Smooth operation and durable components are essential.",
       "Lubricants and additives that enhance durability.",
       "MOLYKOTE™ lubricants (friction, wear, corrosion protection)\nMULTIBASE® (anti-scratch additive)"
        );
    public Sensing sensing = new Sensing(
       "Interconnects, sensors and electro-mechanical actuators must be dependable, accurate and upgradable.",
       "Electrically-friendly, flame-retardant and halogen-free materials for connectors, bobbins, bus bars and power control units, as well as low-emission, creep-resistant homopolymer gears and locking systems.",
       "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nZYTEL® EF / FR / NH series\nZYTEL® LCPA series\nZYTEL® HTN EF series"
        );
}

public class Chasis
{
    // public Lightweighting lightweighting = new Lightweighting();

    public Lightweighting lightweighting = new Lightweighting(
         "Auto EE applications are part of the vehicle weight reduction equation.",
         "Wide product range of thermally-conductive and heat-resistant performance materials to replace metal.",
         "CRASTIN® (hydrolysis and heat resistance)\nZYTEL® HTN (thermal conductivity and hydrolysis)"
         );
    public Safety safety = new Safety(
        "Thermal management and heat-related safety considerations are critical for the electrification and automation components that optimize powertrain and chassis operations in electric vehicles.",
        "Wide range of thermal management, heat-resistant and flame-retardant materials.",
        "BETACOOL™ (coolant system)\nCRASTIN® (EMI shielding for electronics, plus high-voltage resistance)\nKAPTON® (for cabin heater components)\nPCM (phase change material for latent heat storage)\nPI-based heater products\nVAMAC® (halogen-free, low-smoke cable jacketing and insulation)\nZYTEL® (for extruded coolant pipes)"
         );
    public NVH nvh = new NVH(
       "Ride experience is more important than ever as autonomous vehicles become work and social environments. Acoustical performance will be essential.",
       "Portfolio of specialty adhesives that reduce vibrational energy.",
       "MEGUM™\nTHIXON™\nROBOND™\nrubber-to-substrate bonding agents (bonding component brackets and mounts)"
        );
    public Durability durability = new Durability(
       "",
       "",
       ""
        );
    public Sensing sensing = new Sensing(
       "Efficient, high-performance power control units and automated assists will be essential to vehicle electrification and autonomy. Interconnects, sensors and electro-mechanical actuators must be dependable, accurate and upgradable.",
       "Control unit connector, sensor, semiconductor and circuit board advanced material technologies for safe and reliable vehicle connectivity and autonomous operation. This includes, electrically-friendly, flame-retardant and halogen-free materials for connectors, distribution boxes, wires & cables and electronic controllers. Also, low-emission, creep-resistant homopolymer gears and locking systems.",
       "CRASTIN® HR / FR series\nDELRIN® 100/500 series\nPhoto resists;\nMEGAPOSIT™\nMICROPOSIT™\nPlating, substrates;\nCIRCUPOSIT™\nCONDUCTRON™\nDURAPOSIT™\nKAPTON™\nMICROFILL™\nPYRALUX™\nRISTON™\nPolishers, cleaners, conductive pastes\nZYTEL® EF / FR / NH series\nZYTEL® LCPA series\nZYTEL® HTN EF series"
        );
}



public class Lightweighting
{
    public Lightweighting(string a, string b, string c)
    {
        data.Add(a);
        data.Add(b);
        data.Add(c);
    }

    public List<string> data = new List<string>();
    public string[] data2 = new string[3];

}
public class Safety
{
    public List<string> data = new List<string>();
    public Safety(string a, string b, string c)
    {
        data.Add(a);
        data.Add(b);
        data.Add(c);
    }
}
public class NVH
{
    public List<string> data = new List<string>();
    public NVH(string a, string b, string c)
    {
        data.Add(a);
        data.Add(b);
        data.Add(c);
    }
}
public class Durability
{
    public List<string> data = new List<string>();
    public Durability(string a, string b, string c)
    {
        data.Add(a);
        data.Add(b);
        data.Add(c);
    }
}
public class Sensing
{
    public List<string> data = new List<string>();
    public Sensing(string a, string b, string c)
    {
        data.Add(a);
        data.Add(b);
        data.Add(c);
    }
}
