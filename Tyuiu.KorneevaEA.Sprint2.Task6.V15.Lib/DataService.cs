﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.KorneevaEA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1:
                case 8:
                case 15:
                case 22:
                case 29:
                case 36:
                case 43:
                case 50:
                case 57:
                case 64:
                case 71:
                case 78:
                case 85:
                case 92:
                case 99:
                case 106:
                case 113:
                case 120:
                case 127:
                case 134:
                case 141:
                case 148:
                case 155:
                case 162:
                case 169:
                case 176:
                case 183:
                case 190:
                case 197:
                case 204:
                case 211:
                case 218:
                case 225:
                case 232:
                case 239:
                case 246:
                case 253:
                case 260:
                case 267:
                case 274:
                case 281:
                case 288:
                case 295:
                case 302:
                case 309:
                case 316:
                case 323:
                case 330:
                case 337:
                case 344:
                case 351:
                case 358:
                case 365:
                    return "Понедельник";
                case 2:
                case 9:
                case 16:
                case 23:
                case 30:
                case 37:
                case 44:
                case 51:
                case 58:
                case 65:
                case 72:
                case 79:
                case 86:
                case 93:
                case 100:
                case 107:
                case 114:
                case 121:
                case 128:
                case 135:
                case 142:
                case 149:
                case 156:
                case 163:
                case 170:
                case 177:
                case 184:
                case 191:
                case 198:
                case 205:
                case 212:
                case 219:
                case 226:
                case 233:
                case 240:
                case 247:
                case 254:
                case 261:
                case 268:
                case 275:
                case 282:
                case 289:
                case 296:
                case 303:
                case 310:
                case 317:
                case 324:
                case 331:
                case 338:
                case 345:
                case 352:
                case 359:
                    return "Вторник";
                case 3:
                case 10:
                case 17:
                case 24:
                case 31:
                case 38:
                case 45:
                case 52:
                case 59:
                case 66:
                case 73:
                case 80:
                case 87:
                case 94:
                case 101:
                case 108:
                case 115:
                case 122:
                case 129:
                case 136:
                case 143:
                case 150:
                case 157:
                case 164:
                case 171:
                case 178:
                case 185:
                case 192:
                case 199:
                case 206:
                case 213:
                case 220:
                case 227:
                case 234:
                case 241:
                case 248:
                case 255:
                case 262:
                case 269:
                case 276:
                case 283:
                case 290:
                case 297:
                case 304:
                case 311:
                case 318:
                case 325:
                case 332:
                case 339:
                case 346:
                case 353:
                case 360:
                    return "Среда";
                case 4:
                case 11:
                case 18:
                case 25:
                case 32:
                case 39:
                case 46:
                case 53:
                case 60:
                case 67:
                case 74:
                case 81:
                case 88:
                case 95:
                case 102:
                case 109:
                case 116:
                case 123:
                case 130:
                case 137:
                case 144:
                case 151:
                case 158:
                case 165:
                case 172:
                case 179:
                case 186:
                case 193:
                case 200:
                case 207:
                case 214:
                case 221:
                case 228:
                case 235:
                case 242:
                case 249:
                case 256:
                case 263:
                case 270:
                case 277:
                case 284:
                case 291:
                case 298:
                case 305:
                case 312:
                case 319:
                case 326:
                case 333:
                case 340:
                case 347:
                case 354:
                case 361:
                    return "Четверг";
                case 5:
                case 12:
                case 19:
                case 26:
                case 33:
                case 40:
                case 47:
                case 54:
                case 61:
                case 68:
                case 75:
                case 82:
                case 89:
                case 96:
                case 103:
                case 110:
                case 117:
                case 124:
                case 131:
                case 138:
                case 145:
                case 152:
                case 159:
                case 166:
                case 173:
                case 180:
                case 187:
                case 194:
                case 201:
                case 208:
                case 215:
                case 222:
                case 229:
                case 236:
                case 243:
                case 250:
                case 257:
                case 264:
                case 271:
                case 278:
                case 285:
                case 292:
                case 299:
                case 306:
                case 313:
                case 320:
                case 327:
                case 334:
                case 341:
                case 348:
                case 355:
                case 362:
                    return "Пятница";
                case 6:
                case 13:
                case 20:
                case 27:
                case 34:
                case 41:
                case 48:
                case 55:
                case 62:
                case 69:
                case 76:
                case 83:
                case 90:
                case 97:
                case 104:
                case 111:
                case 118:
                case 125:
                case 132:
                case 139:
                case 146:
                case 153:
                case 160:
                case 167:
                case 174:
                case 181:
                case 188:
                case 195:
                case 202:
                case 209:
                case 216:
                case 223:
                case 230:
                case 237:
                case 244:
                case 251:
                case 258:
                case 265:
                case 272:
                case 279:
                case 286:
                case 293:
                case 300:
                case 307:
                case 314:
                case 321:
                case 328:
                case 335:
                case 342:
                case 349:
                case 356:
                case 363:
                    return "Суббота";
                case 7:
                case 14:
                case 21:
                case 28:
                case 35:
                case 42:
                case 49:
                case 56:
                case 63:
                case 70:
                case 77:
                case 84:
                case 91:
                case 98:
                case 105:
                case 112:
                case 119:
                case 126:
                case 133:
                case 140:
                case 147:
                case 154:
                case 161:
                case 168:
                case 175:
                case 182:
                case 189:
                case 196:
                case 203:
                case 210:
                case 217:
                case 224:
                case 231:
                case 238:
                case 245:
                case 252:
                case 259:
                case 266:
                case 273:
                case 280:
                case 287:
                case 294:
                case 301:
                case 308:
                case 315:
                case 322:
                case 329:
                case 336:
                case 343:
                case 350:
                case 357:
                case 364:
                    return "Воскресенье";
                default: throw new ArgumentException($"День должен быть от 1 до 365. Значение {value}");
            }
        }
    }
}
