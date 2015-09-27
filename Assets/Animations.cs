﻿//using UnityEngine;
using System.Collections;

public class Animations : UnityEngine.MonoBehaviour {

public static AIBehavior.Motion[] anim_1 = new AIBehavior.Motion[]{
    new AIBehavior.Motion("moved", 0, 115, 110),
    new AIBehavior.Motion("dot", 852, 115, 110),
    new AIBehavior.Motion("dragged", 1091, 115, 111),
    new AIBehavior.Motion("dragged", 1097, 115, 112),
    new AIBehavior.Motion("dragged", 1103, 115, 113),
    new AIBehavior.Motion("dragged", 1109, 115, 114),
    new AIBehavior.Motion("dragged", 1116, 115, 115),
    new AIBehavior.Motion("dragged", 1122, 115, 117),
    new AIBehavior.Motion("dragged", 1130, 115, 118),
    new AIBehavior.Motion("dragged", 1137, 115, 119),
    new AIBehavior.Motion("dragged", 1142, 115, 120),
    new AIBehavior.Motion("dragged", 1148, 115, 121),
    new AIBehavior.Motion("dragged", 1155, 115, 122),
    new AIBehavior.Motion("dragged", 1168, 115, 123),
    new AIBehavior.Motion("dragged", 1174, 115, 124),
    new AIBehavior.Motion("dragged", 1207, 115, 125),
    new AIBehavior.Motion("dragged", 1226, 115, 126),
    new AIBehavior.Motion("dragged", 1232, 114, 127),
    new AIBehavior.Motion("dragged", 1245, 114, 128),
    new AIBehavior.Motion("dragged", 1251, 113, 129),
    new AIBehavior.Motion("dragged", 1258, 113, 130),
    new AIBehavior.Motion("dragged", 1284, 113, 131),
    new AIBehavior.Motion("dragged", 1311, 113, 132),
    new AIBehavior.Motion("dragged", 1329, 113, 133),
    new AIBehavior.Motion("dragged", 1335, 113, 134),
    new AIBehavior.Motion("dragged", 1348, 113, 135),
    new AIBehavior.Motion("dragged", 1355, 113, 136),
    new AIBehavior.Motion("dragged", 1361, 113, 137),
    new AIBehavior.Motion("dragged", 1413, 113, 138),
    new AIBehavior.Motion("dragged", 1419, 112, 138),
    new AIBehavior.Motion("dragged", 1431, 112, 139),
    new AIBehavior.Motion("dragged", 1458, 112, 140),
    new AIBehavior.Motion("dragged", 1503, 112, 141),
    new AIBehavior.Motion("moved", 1658, 112, 140),
    new AIBehavior.Motion("moved", 1684, 113, 139),
    new AIBehavior.Motion("moved", 1696, 114, 138),
    new AIBehavior.Motion("moved", 1716, 114, 137),
    new AIBehavior.Motion("moved", 1722, 115, 136),
    new AIBehavior.Motion("moved", 1751, 116, 135),
    new AIBehavior.Motion("moved", 1754, 117, 134),
    new AIBehavior.Motion("moved", 1761, 117, 133),
    new AIBehavior.Motion("moved", 1767, 118, 132),
    new AIBehavior.Motion("moved", 1773, 119, 130),
    new AIBehavior.Motion("moved", 1779, 121, 128),
    new AIBehavior.Motion("moved", 1787, 121, 127),
    new AIBehavior.Motion("moved", 1793, 122, 126),
    new AIBehavior.Motion("moved", 1800, 123, 125),
    new AIBehavior.Motion("moved", 1806, 123, 124),
    new AIBehavior.Motion("moved", 1812, 124, 124),
    new AIBehavior.Motion("moved", 1827, 124, 123),
    new AIBehavior.Motion("moved", 1838, 125, 121),
    new AIBehavior.Motion("moved", 1851, 126, 119),
    new AIBehavior.Motion("moved", 1870, 126, 118),
    new AIBehavior.Motion("moved", 1934, 126, 117),
    new AIBehavior.Motion("moved", 2019, 127, 117),
    new AIBehavior.Motion("moved", 2037, 127, 116),
    new AIBehavior.Motion("moved", 2160, 128, 116),
    new AIBehavior.Motion("moved", 2179, 129, 116),
    new AIBehavior.Motion("moved", 2236, 129, 115),
    new AIBehavior.Motion("dot", 2320, 129, 115),
    new AIBehavior.Motion("dragged", 2404, 129, 116),
    new AIBehavior.Motion("dragged", 2416, 129, 117),
    new AIBehavior.Motion("dragged", 2429, 129, 119),
    new AIBehavior.Motion("dragged", 2442, 129, 120),
    new AIBehavior.Motion("dragged", 2448, 129, 121),
    new AIBehavior.Motion("dragged", 2455, 129, 122),
    new AIBehavior.Motion("dragged", 2468, 129, 123),
    new AIBehavior.Motion("dragged", 2487, 129, 124),
    new AIBehavior.Motion("dragged", 2581, 129, 129),
    new AIBehavior.Motion("dragged", 2602, 129, 130),
    new AIBehavior.Motion("dragged", 2638, 129, 131),
    new AIBehavior.Motion("dragged", 2651, 129, 133),
    new AIBehavior.Motion("dragged", 2664, 129, 135),
    new AIBehavior.Motion("dragged", 2677, 129, 138),
    new AIBehavior.Motion("dragged", 2693, 129, 139),
    new AIBehavior.Motion("dragged", 2776, 129, 140),
    new AIBehavior.Motion("moved", 2885, 129, 139),
    new AIBehavior.Motion("moved", 2907, 129, 138),
    new AIBehavior.Motion("moved", 2935, 128, 137),
    new AIBehavior.Motion("moved", 2937, 128, 136),
    new AIBehavior.Motion("moved", 2952, 128, 135),
    new AIBehavior.Motion("moved", 2956, 128, 133),
    new AIBehavior.Motion("moved", 2971, 128, 132),
    new AIBehavior.Motion("moved", 2985, 127, 132),
    new AIBehavior.Motion("moved", 3018, 127, 131),
    new AIBehavior.Motion("moved", 3039, 126, 131),
    new AIBehavior.Motion("moved", 3072, 125, 131),
    new AIBehavior.Motion("moved", 3102, 125, 130),
    new AIBehavior.Motion("moved", 3169, 124, 130),
    new AIBehavior.Motion("moved", 3221, 124, 129),
    new AIBehavior.Motion("moved", 3265, 124, 128),
    new AIBehavior.Motion("dot", 3302, 124, 128),
    new AIBehavior.Motion("dragged", 3335, 125, 128),
    new AIBehavior.Motion("dragged", 3351, 126, 128),
    new AIBehavior.Motion("dragged", 3418, 127, 128),
    new AIBehavior.Motion("dragged", 3451, 128, 128),
    new AIBehavior.Motion("dragged", 3453, 129, 128),
    new AIBehavior.Motion("dragged", 3501, 130, 128),
    new AIBehavior.Motion("dragged", 3651, 131, 128),
    new AIBehavior.Motion("dragged", 3667, 132, 128),
    new AIBehavior.Motion("dragged", 3685, 133, 128),
    new AIBehavior.Motion("dragged", 3734, 134, 128),
    new AIBehavior.Motion("moved", 4117, 135, 128),
    new AIBehavior.Motion("moved", 4121, 136, 128),
    new AIBehavior.Motion("moved", 4237, 150, 130),
    new AIBehavior.Motion("moved", 4250, 151, 130),
    new AIBehavior.Motion("moved", 4266, 152, 130),
    new AIBehavior.Motion("moved", 4269, 153, 130),
    new AIBehavior.Motion("moved", 4284, 155, 130),
    new AIBehavior.Motion("moved", 4299, 156, 130),
    new AIBehavior.Motion("moved", 4302, 157, 130),
    new AIBehavior.Motion("moved", 4316, 158, 130),
    new AIBehavior.Motion("moved", 4351, 159, 130),
    new AIBehavior.Motion("moved", 4443, 160, 130),
    new AIBehavior.Motion("moved", 4456, 161, 130),
    new AIBehavior.Motion("moved", 4468, 162, 129),
    new AIBehavior.Motion("moved", 4481, 163, 129),
    new AIBehavior.Motion("moved", 4487, 164, 129),
    new AIBehavior.Motion("moved", 4577, 165, 129),
    new AIBehavior.Motion("dot", 4706, 165, 129),
    new AIBehavior.Motion("dragged", 4807, 165, 130),
    new AIBehavior.Motion("dragged", 4815, 165, 131),
    new AIBehavior.Motion("dragged", 4828, 165, 132),
    new AIBehavior.Motion("dragged", 4841, 165, 134),
    new AIBehavior.Motion("dragged", 4847, 166, 134),
    new AIBehavior.Motion("dragged", 4855, 166, 136),
    new AIBehavior.Motion("dragged", 4860, 166, 137),
    new AIBehavior.Motion("dragged", 4873, 166, 138),
    new AIBehavior.Motion("dragged", 4879, 166, 139),
    new AIBehavior.Motion("dragged", 4924, 166, 140),
    new AIBehavior.Motion("dragged", 4970, 167, 140),
    new AIBehavior.Motion("dragged", 4989, 168, 140),
    new AIBehavior.Motion("dragged", 5014, 169, 140),
    new AIBehavior.Motion("dragged", 5053, 170, 140),
    new AIBehavior.Motion("dragged", 5053, 171, 140),
    new AIBehavior.Motion("dragged", 5073, 172, 140),
    new AIBehavior.Motion("dragged", 5086, 172, 139),
    new AIBehavior.Motion("dragged", 5117, 172, 138),
    new AIBehavior.Motion("dragged", 5143, 172, 137),
    new AIBehavior.Motion("dragged", 5176, 173, 136),
    new AIBehavior.Motion("dragged", 5195, 173, 135),
    new AIBehavior.Motion("dragged", 5222, 173, 134),
    new AIBehavior.Motion("dragged", 5259, 173, 133),
    new AIBehavior.Motion("dragged", 5343, 173, 132),
    new AIBehavior.Motion("dragged", 5426, 173, 131),
    new AIBehavior.Motion("dragged", 5439, 173, 130),
    new AIBehavior.Motion("dragged", 5447, 174, 129),
    new AIBehavior.Motion("dragged", 5455, 174, 128),
    new AIBehavior.Motion("dragged", 5601, 174, 129),
    new AIBehavior.Motion("dragged", 5627, 174, 130),
    new AIBehavior.Motion("dragged", 5658, 174, 131),
    new AIBehavior.Motion("dragged", 5704, 174, 132),
    new AIBehavior.Motion("dragged", 5723, 174, 133),
    new AIBehavior.Motion("dragged", 5742, 174, 134),
    new AIBehavior.Motion("dragged", 5748, 175, 134),
    new AIBehavior.Motion("dragged", 5761, 175, 135),
    new AIBehavior.Motion("dragged", 5768, 175, 136),
    new AIBehavior.Motion("dragged", 5794, 175, 137),
    new AIBehavior.Motion("dragged", 5800, 176, 137),
    new AIBehavior.Motion("dragged", 5871, 177, 137),
    new AIBehavior.Motion("dragged", 5884, 178, 137),
    new AIBehavior.Motion("dragged", 5941, 179, 137),
    new AIBehavior.Motion("dragged", 6006, 180, 137),
    new AIBehavior.Motion("dragged", 6051, 180, 136),
    new AIBehavior.Motion("dragged", 6071, 180, 135),
    new AIBehavior.Motion("dragged", 6115, 180, 134),
    new AIBehavior.Motion("dragged", 6186, 180, 133),
    new AIBehavior.Motion("dragged", 6218, 180, 132),
    new AIBehavior.Motion("dragged", 6275, 180, 131),
    new AIBehavior.Motion("moved", 6726, 181, 131),
    new AIBehavior.Motion("moved", 6732, 182, 131),
    new AIBehavior.Motion("moved", 6739, 184, 131),
    new AIBehavior.Motion("moved", 6745, 185, 131),
    new AIBehavior.Motion("moved", 6752, 186, 131),
    new AIBehavior.Motion("moved", 6757, 188, 131),
    new AIBehavior.Motion("moved", 6764, 190, 131),
    new AIBehavior.Motion("moved", 6770, 191, 131),
    new AIBehavior.Motion("moved", 6776, 192, 131),
    new AIBehavior.Motion("moved", 6782, 194, 131),
    new AIBehavior.Motion("moved", 6789, 195, 131),
    new AIBehavior.Motion("moved", 6795, 196, 131),
    new AIBehavior.Motion("moved", 6802, 197, 132),
    new AIBehavior.Motion("moved", 6825, 198, 132),
    new AIBehavior.Motion("moved", 6905, 199, 132),
    new AIBehavior.Motion("moved", 7032, 198, 132),
    new AIBehavior.Motion("moved", 7045, 197, 132),
    new AIBehavior.Motion("moved", 7071, 196, 132),
    new AIBehavior.Motion("moved", 7090, 195, 132),
    new AIBehavior.Motion("moved", 7097, 194, 132),
    new AIBehavior.Motion("moved", 7129, 193, 132),
    new AIBehavior.Motion("moved", 7155, 193, 131),
    new AIBehavior.Motion("moved", 7162, 192, 131),
    new AIBehavior.Motion("moved", 7188, 191, 131),
    new AIBehavior.Motion("moved", 7202, 190, 131),
    new AIBehavior.Motion("moved", 7227, 190, 130),
    new AIBehavior.Motion("dot", 7286, 190, 130),
    new AIBehavior.Motion("dragged", 7441, 190, 131),
    new AIBehavior.Motion("dragged", 7447, 189, 131),
    new AIBehavior.Motion("dragged", 7460, 189, 132),
    new AIBehavior.Motion("dragged", 7473, 188, 133),
    new AIBehavior.Motion("dragged", 7479, 188, 134),
    new AIBehavior.Motion("dragged", 7486, 187, 134),
    new AIBehavior.Motion("dragged", 7492, 187, 135),
    new AIBehavior.Motion("dragged", 7518, 187, 136),
    new AIBehavior.Motion("dragged", 7538, 187, 137),
    new AIBehavior.Motion("dragged", 7555, 186, 137),
    new AIBehavior.Motion("dragged", 7557, 186, 138),
    new AIBehavior.Motion("dragged", 7609, 186, 139),
    new AIBehavior.Motion("dragged", 7648, 187, 139),
    new AIBehavior.Motion("dragged", 7661, 188, 139),
    new AIBehavior.Motion("dragged", 7680, 189, 139),
    new AIBehavior.Motion("dragged", 7706, 190, 139),
    new AIBehavior.Motion("dragged", 7719, 191, 139),
    new AIBehavior.Motion("dragged", 7738, 192, 139),
    new AIBehavior.Motion("dragged", 7790, 193, 139),
    new AIBehavior.Motion("dragged", 7817, 194, 138),
    new AIBehavior.Motion("dragged", 7822, 195, 137),
    new AIBehavior.Motion("dragged", 7874, 196, 137),
    new AIBehavior.Motion("dragged", 7880, 196, 136),
    new AIBehavior.Motion("dragged", 7901, 196, 135),
    new AIBehavior.Motion("dragged", 7906, 196, 134),
    new AIBehavior.Motion("dragged", 7926, 196, 133),
    new AIBehavior.Motion("dragged", 7953, 196, 132),
    new AIBehavior.Motion("dragged", 7985, 196, 131),
    new AIBehavior.Motion("dragged", 7998, 196, 130),
    new AIBehavior.Motion("dragged", 8115, 195, 130),
    new AIBehavior.Motion("dragged", 8128, 194, 130),
    new AIBehavior.Motion("dragged", 8161, 193, 130),
    new AIBehavior.Motion("dragged", 8193, 192, 130),
    new AIBehavior.Motion("dragged", 8226, 191, 130),
    new AIBehavior.Motion("dragged", 8267, 190, 130),
    new AIBehavior.Motion("dragged", 8304, 190, 131),
    new AIBehavior.Motion("dragged", 8389, 189, 131),
    new AIBehavior.Motion("moved", 8525, 190, 131),
    new AIBehavior.Motion("moved", 8531, 191, 131),
    new AIBehavior.Motion("moved", 8550, 192, 131),
    new AIBehavior.Motion("moved", 8589, 193, 131),
    new AIBehavior.Motion("moved", 8602, 194, 131),
    new AIBehavior.Motion("moved", 8608, 195, 131),
    new AIBehavior.Motion("moved", 8616, 196, 131),
    new AIBehavior.Motion("moved", 8627, 197, 131),
    new AIBehavior.Motion("moved", 8634, 198, 131),
    new AIBehavior.Motion("moved", 8653, 199, 131),
    new AIBehavior.Motion("moved", 8666, 201, 131),
    new AIBehavior.Motion("moved", 8679, 202, 131),
    new AIBehavior.Motion("moved", 8691, 203, 131),
    new AIBehavior.Motion("moved", 8730, 204, 131),
    new AIBehavior.Motion("dot", 8878, 204, 131),
    new AIBehavior.Motion("dragged", 8937, 204, 132),
    new AIBehavior.Motion("dragged", 8955, 204, 133),
    new AIBehavior.Motion("dragged", 8982, 203, 133),
    new AIBehavior.Motion("dragged", 8994, 203, 134),
    new AIBehavior.Motion("dragged", 9006, 203, 135),
    new AIBehavior.Motion("dragged", 9032, 203, 136),
    new AIBehavior.Motion("dragged", 9052, 203, 137),
    new AIBehavior.Motion("dragged", 9078, 203, 138),
    new AIBehavior.Motion("dragged", 9103, 203, 139),
    new AIBehavior.Motion("dragged", 9168, 203, 140),
    new AIBehavior.Motion("dragged", 9239, 203, 141),
    new AIBehavior.Motion("dragged", 9342, 203, 140),
    new AIBehavior.Motion("dragged", 9355, 203, 139),
    new AIBehavior.Motion("dragged", 9362, 203, 138),
    new AIBehavior.Motion("dragged", 9375, 203, 137),
    new AIBehavior.Motion("dragged", 9394, 203, 136),
    new AIBehavior.Motion("dragged", 9446, 203, 135),
    new AIBehavior.Motion("dragged", 9458, 204, 134),
    new AIBehavior.Motion("dragged", 9484, 204, 133),
    new AIBehavior.Motion("dragged", 9588, 205, 133),
    new AIBehavior.Motion("dragged", 9729, 206, 133),
    new AIBehavior.Motion("dragged", 9736, 206, 132),
    new AIBehavior.Motion("dragged", 9768, 207, 132),
    new AIBehavior.Motion("dragged", 9788, 208, 132),
    new AIBehavior.Motion("moved", 10181, 208, 131),
    new AIBehavior.Motion("moved", 10207, 209, 130),
    new AIBehavior.Motion("moved", 10220, 209, 129),
    new AIBehavior.Motion("moved", 10247, 210, 128),
    new AIBehavior.Motion("moved", 10253, 211, 127),
    new AIBehavior.Motion("moved", 10258, 212, 127),
    new AIBehavior.Motion("moved", 10265, 212, 126),
    new AIBehavior.Motion("moved", 10271, 213, 126),
    new AIBehavior.Motion("moved", 10278, 214, 125),
    new AIBehavior.Motion("moved", 10284, 214, 124),
    new AIBehavior.Motion("moved", 10336, 215, 123),
    new AIBehavior.Motion("moved", 10348, 215, 121),
    new AIBehavior.Motion("moved", 10414, 218, 117),
    new AIBehavior.Motion("moved", 10476, 219, 117),
    new AIBehavior.Motion("dot", 10674, 219, 117),
    new AIBehavior.Motion("dragged", 10677, 219, 118),
    new AIBehavior.Motion("dragged", 10690, 218, 118),
    new AIBehavior.Motion("dragged", 10706, 218, 119),
    new AIBehavior.Motion("dragged", 10708, 218, 120),
    new AIBehavior.Motion("dragged", 10740, 218, 121),
    new AIBehavior.Motion("dragged", 10756, 218, 122),
    new AIBehavior.Motion("dragged", 10759, 218, 123),
    new AIBehavior.Motion("dragged", 10773, 217, 124),
    new AIBehavior.Motion("dragged", 10822, 217, 125),
    new AIBehavior.Motion("dragged", 10874, 216, 127),
    new AIBehavior.Motion("dragged", 10875, 216, 128),
    new AIBehavior.Motion("dragged", 10887, 216, 129),
    new AIBehavior.Motion("dragged", 10888, 216, 130),
    new AIBehavior.Motion("dragged", 10902, 216, 131),
    new AIBehavior.Motion("dragged", 10916, 216, 132),
    new AIBehavior.Motion("dragged", 10933, 216, 133),
    new AIBehavior.Motion("dragged", 10972, 216, 134),
    new AIBehavior.Motion("dragged", 10989, 216, 136),
    new AIBehavior.Motion("dragged", 11006, 216, 137),
    new AIBehavior.Motion("dragged", 11056, 216, 138),
    new AIBehavior.Motion("dragged", 11108, 216, 139),
    new AIBehavior.Motion("dragged", 11140, 216, 140),
    new AIBehavior.Motion("moved", 11372, 216, 139),
    new AIBehavior.Motion("moved", 11389, 216, 138),
    new AIBehavior.Motion("moved", 11406, 216, 137),
    new AIBehavior.Motion("moved", 11439, 216, 135),
    new AIBehavior.Motion("moved", 11455, 216, 134),
    new AIBehavior.Motion("moved", 11472, 216, 133),
    new AIBehavior.Motion("moved", 11523, 216, 132),
    new AIBehavior.Motion("dot", 11574, 216, 132),
    new AIBehavior.Motion("dragged", 11622, 216, 131),
    new AIBehavior.Motion("dragged", 11672, 216, 130),
    new AIBehavior.Motion("dragged", 11689, 217, 130),
    new AIBehavior.Motion("dragged", 11772, 218, 129),
    new AIBehavior.Motion("dragged", 11792, 218, 128),
    new AIBehavior.Motion("dragged", 11899, 221, 128),
    new AIBehavior.Motion("dragged", 11912, 222, 128),
    new AIBehavior.Motion("dragged", 11914, 222, 127),
    new AIBehavior.Motion("dragged", 11935, 223, 127),
    new AIBehavior.Motion("dragged", 11951, 224, 127),
    new AIBehavior.Motion("moved", 12128, 223, 127),
    new AIBehavior.Motion("moved", 12161, 222, 127),
    new AIBehavior.Motion("moved", 12198, 221, 127),
    new AIBehavior.Motion("moved", 12204, 221, 128),
    new AIBehavior.Motion("moved", 12217, 220, 128),
    new AIBehavior.Motion("moved", 12236, 219, 129),
    new AIBehavior.Motion("moved", 12268, 218, 130),
    new AIBehavior.Motion("moved", 12327, 218, 131),
    new AIBehavior.Motion("moved", 12340, 217, 131),
    new AIBehavior.Motion("moved", 12404, 216, 132),
    new AIBehavior.Motion("dot", 12514, 216, 132),
    new AIBehavior.Motion("dragged", 12553, 217, 132),
    new AIBehavior.Motion("dragged", 12585, 218, 132),
    new AIBehavior.Motion("dragged", 12624, 219, 131),
    new AIBehavior.Motion("dragged", 12682, 220, 131),
    new AIBehavior.Motion("dragged", 12721, 221, 131),
    new AIBehavior.Motion("dragged", 12843, 222, 131),
    new AIBehavior.Motion("dragged", 12904, 222, 134),
    new AIBehavior.Motion("dragged", 12914, 222, 135),
    new AIBehavior.Motion("dragged", 12920, 223, 136),
    new AIBehavior.Motion("dragged", 12939, 223, 137),
    new AIBehavior.Motion("dragged", 12952, 224, 137),
    new AIBehavior.Motion("dragged", 12971, 224, 138),
    new AIBehavior.Motion("dragged", 13004, 225, 138),
    new AIBehavior.Motion("dragged", 13010, 225, 139),
    new AIBehavior.Motion("dragged", 13101, 226, 139),
    new AIBehavior.Motion("moved", 13486, 227, 139),
    new AIBehavior.Motion("moved", 13492, 228, 138),
    new AIBehavior.Motion("moved", 13505, 228, 137),
    new AIBehavior.Motion("moved", 13511, 229, 137),
    new AIBehavior.Motion("moved", 13525, 229, 136),
    new AIBehavior.Motion("moved", 13531, 230, 135),
    new AIBehavior.Motion("moved", 13543, 231, 135),
    new AIBehavior.Motion("moved", 13555, 231, 134),
    new AIBehavior.Motion("moved", 13556, 232, 134),
    new AIBehavior.Motion("moved", 13563, 233, 133),
    new AIBehavior.Motion("moved", 13569, 234, 132),
    new AIBehavior.Motion("moved", 13582, 235, 132),
    new AIBehavior.Motion("moved", 13588, 237, 131),
    new AIBehavior.Motion("moved", 13602, 238, 131),
    new AIBehavior.Motion("moved", 13609, 239, 130),
    new AIBehavior.Motion("moved", 13620, 240, 129),
    new AIBehavior.Motion("moved", 13640, 241, 129),
    new AIBehavior.Motion("moved", 13653, 241, 128),
    new AIBehavior.Motion("moved", 13659, 242, 128),
    new AIBehavior.Motion("dot", 13926, 242, 128),
    new AIBehavior.Motion("dragged", 13934, 241, 128),
    new AIBehavior.Motion("dragged", 13972, 240, 128),
    new AIBehavior.Motion("dragged", 14004, 239, 128),
    new AIBehavior.Motion("dragged", 14018, 238, 128),
    new AIBehavior.Motion("dragged", 14043, 238, 129),
    new AIBehavior.Motion("dragged", 14050, 237, 129),
    new AIBehavior.Motion("dragged", 14081, 237, 130),
    new AIBehavior.Motion("dragged", 14121, 236, 130),
    new AIBehavior.Motion("dragged", 14133, 236, 131),
    new AIBehavior.Motion("dragged", 14210, 236, 132),
    new AIBehavior.Motion("dragged", 14371, 237, 132),
    new AIBehavior.Motion("dragged", 14416, 238, 132),
    new AIBehavior.Motion("dragged", 14436, 239, 132),
    new AIBehavior.Motion("dragged", 14474, 239, 133),
    new AIBehavior.Motion("dragged", 14500, 240, 133),
    new AIBehavior.Motion("dragged", 14507, 240, 134),
    new AIBehavior.Motion("dragged", 14538, 241, 134),
    new AIBehavior.Motion("dragged", 14551, 241, 135),
    new AIBehavior.Motion("dragged", 14603, 242, 135),
    new AIBehavior.Motion("dragged", 14647, 243, 135),
    new AIBehavior.Motion("dragged", 14667, 243, 136),
    new AIBehavior.Motion("dragged", 14725, 243, 137),
    new AIBehavior.Motion("dragged", 14809, 242, 137),
    new AIBehavior.Motion("dragged", 14841, 242, 138),
    new AIBehavior.Motion("dragged", 14866, 241, 138),
    new AIBehavior.Motion("dragged", 14924, 240, 139),
    new AIBehavior.Motion("dragged", 15002, 239, 139),
    new AIBehavior.Motion("dragged", 15034, 238, 139),
    new AIBehavior.Motion("dragged", 15106, 237, 139),
    new AIBehavior.Motion("dragged", 15190, 236, 139),
    new AIBehavior.Motion("dragged", 15228, 235, 139),
    new AIBehavior.Motion("dragged", 15364, 234, 139),
    new AIBehavior.Motion("dragged", 15390, 234, 138),
    new AIBehavior.Motion("dragged", 15474, 233, 138),
};

}
