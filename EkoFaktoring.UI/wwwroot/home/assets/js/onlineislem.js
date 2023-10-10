$("#contact_form").submit(function (event) {
    event.preventDefault();
});

//sms onlayla butonu tıklanma eventi
$("#next-sms-btn").click(function () {
    $("#next-sms-div").addClass("d-none");
    $("#next-div").removeClass("d-none");
    $("#smsCodeDiv").removeClass("d-none");
});

//sonraki butonu tıklanma eventi
$("#next-btn").click(function () {
    //$(`[data-tab="#personal-loan"]`).trigger("click");
    $("#islem-step").click();
    $("#contact-step").addClass("active-btn-item");
});

//gönder butonu tıklanma eventi
$("#submitBtn").click(function () {
    $("#done-step").click();
    $("#contact-step").addClass("active-btn-item");
    $("#islem-step").addClass("active-btn-item");
});


$("#islem_form").submit(function (event) {
    event.preventDefault();
});


