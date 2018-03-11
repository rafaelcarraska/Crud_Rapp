
function fecharmodal() {
    $(".popup").bPopup().close();
    $('.b-modal').css('display', 'none');
}

function divalert(texto, tipo) {
    $('.rowerros').append('<div class="col-md-11 divalert column alert ' + tipo + '" >'
        + '<label id="lbalert" class="lbalert">' + texto + '</label></div>');

    $('.rowerros .divalert:last').delay(6000).slideUp(400);
}
