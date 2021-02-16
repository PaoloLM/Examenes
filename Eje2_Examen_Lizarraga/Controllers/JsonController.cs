using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eje2_Examen_Lizarraga.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExtraerJson(string json)
        {

            // se produce un error al colocar el json
            //var contenidojson = '[["knew",489,150,26,133,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would tell",491,538,24,113,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["were/was",551,148,27,129,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would inform",550,472,28,163,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["won",606,152,25,118,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would travel",610,518,27,120,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["went",664,185,26,108,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would be",667,596,25,112,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would work",721,127,29,136,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["spoke",723,527,21,101,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["wouldn$t do",782,116,27,163,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["were/was",779,517,28,123,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["became",835,136,26,136,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would change",835,575,27,141,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["flew",924,149,26,138,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would visit",921,525,28,169,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["knew",980,171,24,111,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would be",976,587,31,132,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would be",1039,164,27,109,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["had",1036,546,24,108,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["passed",1095,177,22,104,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would go",1091,565,26,107,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["cut",1149,182,25,104,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0],["would look",1151,534,26,133,"",0,"Arial","14","0000CC","255","255","255","0.5","666666","","","1","4",0]]';
            /*
             
                if (!window.JSON) {
                window.JSON = {
                    parse: function(sJSON) { return eval('(' + sJSON + ')'); },
                    stringify: (function () {
                        var toString = Object.prototype.toString;
                        var isArray = Array.isArray || function (a) { return toString.call(a) === '[object Array]'; };
                        var escMap = {'"': '\\"', '\\': '\\\\', '\b': '\\b', '\f': '\\f', '\n': '\\n', '\r': '\\r', '\t': '\\t'};
                        var escFunc = function (m) { return escMap[m] || '\\u' + (m.charCodeAt(0) + 0x10000).toString(16).substr(1); };
                        var escRE = /[\\"\u0000-\u001F\u2028\u2029]/g;
                        return function stringify(value) {
                            if (value == null) {
                                return 'null';
                            } else if (typeof value === 'number') {
                                return isFinite(value) ? value.toString() : 'null';
                            } else if (typeof value === 'boolean') {
                                return value.toString();
                            } else if (typeof value === 'object') {
                                if (typeof value.toJSON === 'function') {
                                    return stringify(value.toJSON());
                                } else if (isArray(value)) {
                                    var res = '[';
                                    for (var i = 0; i < value.length; i++)
                                        res += (i ? ', ' : '') + stringify(value[i]);
                                    return res + ']';
                                } else if (toString.call(value) === '[object Object]') {
                                    var tmp = [];
                                    for (var k in value) {
                                        if (value.hasOwnProperty(k))
                                            tmp.push(stringify(k) + ': ' + stringify(value[k]));
                                    }
                                    return '{' + tmp.join(', ') + '}';
                                }
                            }
                            return '"' + value.toString().replace(escRE, escFunc) + '"';
                        };
                    })()
                };
            }

             
             */
            return RedirectToAction("Index");
        }
    }
}