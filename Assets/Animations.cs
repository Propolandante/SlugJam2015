﻿//using UnityEngine;
using System.Collections;

public class Animations : UnityEngine.MonoBehaviour {

public static AIBehavior.Motion[] anim_1 = new AIBehavior.Motion[]{
    new AIBehavior.Motion("moved", 0, 131, 100),
    new AIBehavior.Motion("dot", 231, 131, 100),
    new AIBehavior.Motion("dragged", 303, 131, 102),
    new AIBehavior.Motion("dragged", 311, 131, 106),
    new AIBehavior.Motion("dragged", 318, 131, 109),
    new AIBehavior.Motion("dragged", 327, 133, 119),
    new AIBehavior.Motion("dragged", 334, 136, 127),
    new AIBehavior.Motion("dragged", 343, 137, 134),
    new AIBehavior.Motion("dragged", 350, 139, 139),
    new AIBehavior.Motion("dragged", 358, 140, 143),
    new AIBehavior.Motion("dragged", 367, 142, 146),
    new AIBehavior.Motion("dragged", 374, 142, 147),
    new AIBehavior.Motion("dragged", 383, 144, 149),
    new AIBehavior.Motion("dragged", 390, 149, 150),
    new AIBehavior.Motion("dragged", 399, 154, 150),
    new AIBehavior.Motion("dragged", 406, 160, 150),
    new AIBehavior.Motion("dragged", 415, 164, 150),
    new AIBehavior.Motion("dragged", 422, 171, 146),
    new AIBehavior.Motion("dragged", 431, 174, 145),
    new AIBehavior.Motion("dragged", 438, 176, 142),
    new AIBehavior.Motion("dragged", 446, 181, 139),
    new AIBehavior.Motion("dragged", 454, 185, 135),
    new AIBehavior.Motion("dragged", 463, 187, 131),
    new AIBehavior.Motion("dragged", 470, 188, 128),
    new AIBehavior.Motion("dragged", 479, 188, 126),
    new AIBehavior.Motion("dragged", 486, 188, 124),
    new AIBehavior.Motion("dragged", 495, 188, 121),
    new AIBehavior.Motion("dragged", 502, 187, 120),
    new AIBehavior.Motion("dragged", 511, 186, 118),
    new AIBehavior.Motion("dragged", 518, 185, 118),
    new AIBehavior.Motion("moved", 567, 185, 119),
    new AIBehavior.Motion("moved", 607, 184, 119),
    new AIBehavior.Motion("moved", 631, 182, 120),
    new AIBehavior.Motion("moved", 639, 180, 122),
    new AIBehavior.Motion("moved", 647, 178, 124),
    new AIBehavior.Motion("moved", 655, 177, 125),
    new AIBehavior.Motion("moved", 663, 177, 127),
    new AIBehavior.Motion("moved", 671, 177, 128),
    new AIBehavior.Motion("moved", 679, 177, 131),
    new AIBehavior.Motion("moved", 687, 177, 134),
    new AIBehavior.Motion("moved", 694, 177, 139),
    new AIBehavior.Motion("moved", 702, 177, 148),
    new AIBehavior.Motion("moved", 711, 177, 153),
    new AIBehavior.Motion("moved", 719, 177, 156),
    new AIBehavior.Motion("moved", 727, 177, 159),
    new AIBehavior.Motion("moved", 735, 177, 162),
    new AIBehavior.Motion("moved", 743, 177, 164),
    new AIBehavior.Motion("moved", 750, 177, 167),
    new AIBehavior.Motion("moved", 767, 175, 169),
    new AIBehavior.Motion("moved", 774, 173, 169),
    new AIBehavior.Motion("moved", 783, 171, 169),
    new AIBehavior.Motion("moved", 791, 168, 169),
    new AIBehavior.Motion("moved", 799, 167, 169),
    new AIBehavior.Motion("moved", 815, 166, 169),
    new AIBehavior.Motion("moved", 839, 165, 169),
    new AIBehavior.Motion("moved", 855, 164, 168),
    new AIBehavior.Motion("moved", 876, 161, 167),
    new AIBehavior.Motion("moved", 879, 159, 166),
    new AIBehavior.Motion("moved", 887, 157, 165),
    new AIBehavior.Motion("moved", 895, 156, 164),
    new AIBehavior.Motion("moved", 903, 154, 163),
    new AIBehavior.Motion("moved", 911, 153, 162),
    new AIBehavior.Motion("moved", 919, 153, 161),
    new AIBehavior.Motion("moved", 927, 153, 160),
    new AIBehavior.Motion("moved", 935, 152, 160),
    new AIBehavior.Motion("moved", 951, 152, 159),
    new AIBehavior.Motion("moved", 959, 152, 158),
    new AIBehavior.Motion("dot", 960, 152, 158),
    new AIBehavior.Motion("dragged", 966, 150, 157),
    new AIBehavior.Motion("dragged", 979, 147, 156),
    new AIBehavior.Motion("dragged", 983, 145, 156),
    new AIBehavior.Motion("dragged", 991, 144, 156),
    new AIBehavior.Motion("dragged", 999, 142, 158),
    new AIBehavior.Motion("dragged", 1006, 142, 159),
    new AIBehavior.Motion("dragged", 1015, 142, 161),
    new AIBehavior.Motion("dragged", 1023, 142, 164),
    new AIBehavior.Motion("dragged", 1031, 142, 168),
    new AIBehavior.Motion("dragged", 1039, 142, 171),
    new AIBehavior.Motion("dragged", 1047, 142, 174),
    new AIBehavior.Motion("dragged", 1054, 141, 179),
    new AIBehavior.Motion("dragged", 1062, 141, 183),
    new AIBehavior.Motion("dragged", 1070, 141, 186),
    new AIBehavior.Motion("dragged", 1078, 141, 190),
    new AIBehavior.Motion("dragged", 1086, 141, 192),
    new AIBehavior.Motion("dragged", 1094, 141, 195),
    new AIBehavior.Motion("dragged", 1102, 141, 196),
    new AIBehavior.Motion("dragged", 1119, 141, 197),
    new AIBehavior.Motion("dragged", 1158, 141, 195),
    new AIBehavior.Motion("moved", 1177, 145, 192),
    new AIBehavior.Motion("moved", 1183, 147, 192),
    new AIBehavior.Motion("moved", 1192, 150, 192),
    new AIBehavior.Motion("moved", 1199, 152, 191),
    new AIBehavior.Motion("moved", 1207, 156, 191),
    new AIBehavior.Motion("moved", 1215, 161, 190),
    new AIBehavior.Motion("moved", 1223, 167, 189),
    new AIBehavior.Motion("moved", 1231, 170, 187),
    new AIBehavior.Motion("moved", 1238, 177, 185),
    new AIBehavior.Motion("moved", 1247, 182, 185),
    new AIBehavior.Motion("moved", 1255, 186, 183),
    new AIBehavior.Motion("moved", 1263, 190, 181),
    new AIBehavior.Motion("moved", 1271, 193, 178),
    new AIBehavior.Motion("moved", 1279, 195, 177),
    new AIBehavior.Motion("moved", 1286, 198, 175),
    new AIBehavior.Motion("moved", 1295, 199, 174),
    new AIBehavior.Motion("moved", 1303, 199, 172),
    new AIBehavior.Motion("moved", 1310, 199, 171),
    new AIBehavior.Motion("moved", 1319, 199, 170),
    new AIBehavior.Motion("moved", 1335, 199, 169),
    new AIBehavior.Motion("dot", 1359, 199, 169),
    new AIBehavior.Motion("dragged", 1415, 199, 170),
    new AIBehavior.Motion("dragged", 1423, 199, 174),
    new AIBehavior.Motion("dragged", 1431, 199, 176),
    new AIBehavior.Motion("dragged", 1438, 199, 179),
    new AIBehavior.Motion("dragged", 1447, 198, 184),
    new AIBehavior.Motion("dragged", 1454, 197, 188),
    new AIBehavior.Motion("dragged", 1462, 197, 192),
    new AIBehavior.Motion("dragged", 1470, 197, 195),
    new AIBehavior.Motion("dragged", 1479, 197, 199),
    new AIBehavior.Motion("dragged", 1486, 197, 200),
    new AIBehavior.Motion("dragged", 1494, 198, 201),
    new AIBehavior.Motion("dragged", 1502, 201, 201),
    new AIBehavior.Motion("dragged", 1511, 205, 202),
    new AIBehavior.Motion("dragged", 1518, 209, 202),
    new AIBehavior.Motion("dragged", 1527, 213, 202),
    new AIBehavior.Motion("dragged", 1534, 214, 202),
    new AIBehavior.Motion("dragged", 1542, 216, 201),
    new AIBehavior.Motion("dragged", 1550, 219, 199),
    new AIBehavior.Motion("dragged", 1559, 222, 197),
    new AIBehavior.Motion("dragged", 1566, 225, 192),
    new AIBehavior.Motion("dragged", 1575, 229, 188),
    new AIBehavior.Motion("dragged", 1582, 232, 185),
    new AIBehavior.Motion("dragged", 1591, 233, 182),
    new AIBehavior.Motion("dragged", 1598, 233, 181),
    new AIBehavior.Motion("dragged", 1606, 233, 180),
    new AIBehavior.Motion("dragged", 1615, 233, 179),
    new AIBehavior.Motion("dragged", 1622, 233, 178),
    new AIBehavior.Motion("dragged", 1630, 230, 176),
    new AIBehavior.Motion("dragged", 1638, 229, 176),
    new AIBehavior.Motion("dragged", 1647, 227, 175),
    new AIBehavior.Motion("dragged", 1654, 225, 175),
    new AIBehavior.Motion("dragged", 1663, 222, 175),
    new AIBehavior.Motion("dragged", 1670, 220, 175),
    new AIBehavior.Motion("dragged", 1679, 219, 175),
    new AIBehavior.Motion("dragged", 1687, 216, 175),
    new AIBehavior.Motion("dragged", 1695, 214, 175),
    new AIBehavior.Motion("dragged", 1703, 213, 175),
    new AIBehavior.Motion("dragged", 1710, 212, 175),
    new AIBehavior.Motion("dragged", 1718, 210, 175),
    new AIBehavior.Motion("dragged", 1734, 208, 176),
    new AIBehavior.Motion("dragged", 1742, 207, 177),
    new AIBehavior.Motion("dragged", 1750, 206, 177),
    new AIBehavior.Motion("dragged", 1758, 205, 177),
    new AIBehavior.Motion("dragged", 1766, 204, 177),
    new AIBehavior.Motion("dragged", 1775, 204, 178),
    new AIBehavior.Motion("moved", 1783, 203, 178),
    new AIBehavior.Motion("moved", 1836, 200, 178),
};

}