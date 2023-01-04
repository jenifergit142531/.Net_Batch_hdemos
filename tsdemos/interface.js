var HindiAudience = /** @class */ (function () {
    function HindiAudience() {
    }
    HindiAudience.prototype.getBollywood = function () {
        return "Cirkus";
    };
    HindiAudience.prototype.getHollywood = function () {
        return "not interested";
    };
    return HindiAudience;
}());
var EnglishAudience = /** @class */ (function () {
    function EnglishAudience() {
    }
    EnglishAudience.prototype.getBollywood = function () {
        return "not interested";
    };
    EnglishAudience.prototype.getHollywood = function () {
        return "Avatar 2";
    };
    EnglishAudience.prototype.getPlace = function () {
        return "PVR";
    };
    EnglishAudience.prototype.getTime = function () {
        return "Night show 10:45 PM IST";
    };
    return EnglishAudience;
}());
//create object
var ba = new HindiAudience();
var ha = new EnglishAudience();
console.log("Bollywood Movie Details", ba.getBollywood());
console.log("Hollywood movie details \nMovie Name : ".concat(ha.getHollywood(), "\nLocation:").concat(ha.getPlace(), "\nShow Time : ").concat(ha.getTime()));
