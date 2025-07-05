// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var yer = "";
var time = new Date();
var saat = time.getHours();
var dakika = time.getMinutes();
var day=time.getDay();
var ulzaman=document.getElementById("ulzaman").style.display="inline-block";
var bi_karikatur=document.getElementById("bi_karikatur").style.display="none";
var lucky_travel=document.getElementById("lucky_travel").style.display="none";

if ((day==5 || day==6 || day==0) && (saat >= 17 && saat <= 19) || (saat==19 && dakika<=30)) {
    yer = "Bİ KARİKATÜR KAFEDEYİM";
    bi_karikatur=document.getElementById("bi_karikatur").style.display="inline-block";
    
} else if ((saat === 19 && dakika >= 30) || (saat >= 20 && saat < 23) || (saat === 23 && dakika <= 30)) {
    yer = "LUCKY TRAVEL KAFEDEYİM";
    lucky_travel=document.getElementById("lucky_travel").style.display="inline-block";
} else {
    yer = "";
    var ulzaman=document.getElementById("ulzaman").style.color="#212121";
    bi_karikatur=document.getElementById("bi_karikatur").style.display="none";
    lucky_travel=document.getElementById("lucky_travel").style.display="none";

}

var yerText = document.getElementById("zaman").innerHTML = yer;
