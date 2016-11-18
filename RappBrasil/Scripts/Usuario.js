
function ModalUsuario(id) {
    LimparUsuario();

    $('#popup').bPopup({
        modalClose: false,
        positionStyle: 'fixed'
    });
}

$(document).on('submit', '#FormUsuario', function (event) {
    event.preventDefault();
    var update = false;
    var Usuario = {
        Cod_Usuario: $('#hdnCod_Usuario').val(),
        Nome: $('#Nome').val(),
        Telefone: $('#Telefone').val(),
        Email: $('#Email').val(),
        Empresa: $('#Empresa').val()
    }
    if ($('#hdnCod_Usuario').val() != 0) {
        update = true;
    }
    var url = "../Home/Save";
    $.ajax({
        url: url,
        type: "POST",
        data: { usuario: Usuario },
        success:function (jsn) {
            successFunction_save(jsn, update)
            },
        error: errorFunction
    });

    fecharmodal();
});

function deletar(Cod_Usuario, Nome) {
    $.confirm({
        title: false,
        content: Nome + ' seá excluida do sistema.',
        animation: 'left',
        confirmButton: 'Sim',
        cancelButton: 'Não',
        keyboardEnabled: true,
        confirm: function () {
            $('#tbusuario .codusuario').each(function () {
                if ($(this).val() == Cod_Usuario) {
                    $(this).closest('tr').remove();
                }
            });
            var url = "../Home/Delete";
            $.ajax({
                url: url,
                type: "POST",
                data: { Cod_Usuario: Cod_Usuario },
                success: successFunction,
                error: errorFunction
            });
        }
    });
}

function Editar(usuario) {
    if (usuario != undefined) {
        var _usuario = JSON.parse(usuario);
        $('#hdnCod_Usuario').val(_usuario.Cod_Usuario);
        $('#Nome').val(_usuario.Nome);
        $('#Telefone').val(_usuario.Telefone);
        $('#Email').val(_usuario.Email);
        $('#Empresa').val(_usuario.Empresa);

        $('#popup').bPopup({
            modalClose: false,
            positionStyle: 'fixed'
        });
    } else {
        divalert('Erro, ao Editar o usuário.', 'alert-danger');
    }
}

function successFunction_save(data, update) {    
    jsn = jQuery.parseJSON(data);
    var Usuario = jsn[0].Usuario;
    var messg = jsn[0].messg;

    if (update) {
        $('#tbusuario .codusuario').each(function () {
            if ($(this).val() == Usuario.Cod_Usuario) {
                $(this).closest('tr').remove();
            }
        });
    }
    Add_Usuario(Usuario);
    successFunction(messg);
}

function Add_Usuario(usuario) {
    $('#tbusuario tbody').append('<tr>' +
                ' <td style="display:none;"><input class="codusuario" type="hidden" value="' + usuario.Cod_Usuario + '" /></td>' +
                ' <td class="tdnome">' + usuario.Nome + '</td>' +
                ' <td class="tdtelefone">' + usuario.Telefone + '</td>' +
                ' <td class="tdemail">' + usuario.Email + '</td>' +
                ' <td class="tdempresa">' + usuario.Empresa + '</td>' +
                ' <td><a href="javascript: Editarget(' + usuario.Cod_Usuario + ')">Editar</a></td>' +
                ' <td><a href="javascript: deletar('+usuario.Cod_Usuario+', \''+usuario.Nome+'\')">Deletar</a></td>'+
                ' </tr>');
}

function Editarget(cod_usuario) {
    $('#tbusuario .codusuario').each(function () {
        if ($(this).val() == cod_usuario) {
            $('#hdnCod_Usuario').val(cod_usuario);
            $('#Nome').val($(this).closest('tr').find('.tdnome').html());
            $('#Telefone').val($(this).closest('tr').find('.tdtelefone').html());
            $('#Email').val($(this).closest('tr').find('.tdemail').html());
            $('#Empresa').val($(this).closest('tr').find('.tdempresa').html());

            $('#popup').bPopup({
                modalClose: false,
                positionStyle: 'fixed'
            });
        }
    });
}

function LimparUsuario() {
    $('#hdnCod_Usuario').val(0);
    $('#Nome').val('');
    $('#Telefone').val('');
    $('#Email').val('');
    $('#Empresa').val('');
}

$(function () {
    $("#Nome").keyup(function () {
        limite(this, 150);
    });

    $("#Telefone").keyup(function () {
        limite(this, 20);
    });

    $("#Email").keyup(function () {
        limite(this, 150);
    });

    $("#Empresa").keyup(function () {
        limite(this, 50);
    });
});

$(document).ready(function () {
    $('.tel').mask('(00) 00000-0000');
});