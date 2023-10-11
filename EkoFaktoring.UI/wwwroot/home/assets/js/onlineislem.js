var step1 = false;
var step2 = false;
var step3 = false;

var smsBtn = $("#next-sms-btn");
var nextBtn = $("#next-btn");
var submitBtn = $("#submitBtn");

$("#contact_form").submit(function (event) {
    event.preventDefault();
});

//sms onlayla butonu tıklanma eventi
smsBtn.click(function () {
    $("#next-sms-div").addClass("d-none");
    $("#next-div").removeClass("d-none");
    $("#smsCodeDiv").removeClass("d-none");
});

//sonraki butonu tıklanma eventi
nextBtn.click(function () {
    //$(`[data-tab="#personal-loan"]`).trigger("click");
    $("#islem-step").click();
    $("#contact-step").addClass("active-btn-item");
});

//gönder butonu tıklanma eventi
submitBtn.click(function () {
    $("#done-step").click();
    $("#contact-step").addClass("active-btn-item");
    $("#islem-step").addClass("active-btn-item");
});


$("#islem_form").submit(function (event) {
    event.preventDefault();
});


