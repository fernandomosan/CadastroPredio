function AprovarUsuario(usuarioId, nome) {
    const url = "/Usuarios/AprovarUsuario";

    $.ajax({
        method: 'POST',
        url: url,
        data: { usuarioId: usuarioId },
        success: function (data) {

            if (data === true) {
                $("#" + usuarioId).removeClass("purple daken-3").addClass("green darken-3").text("Aprovado");

                $("." + usuarioId).children("a").remove();
                $("." + usuarioId).append('<a class="btn-floating blue darken-4 btnAprovar" href="Usuarios/GerenciarUsuarios?usuarioId=' + usuarioId + '&nome=' + nome + '" asp-controller="Usuarios" asp-action="GerenciarUsuario" asp-route-usuarioId"' + usuarioId + '"asp-route-nome="' + nome + '"><i class="material-icons">group</i></a>');

                M.toast({
                    html: "Usuario aprovado",
                    classes: "green darken-3"
                });
            }
            else {
                M.toast({
                    html: "Não foi possível aprovar o usuário"
                });
            }
            
        }
    })
}

function ReprovarUsuario(usuarioId) {
    const url = "/Usuarios/ReprovarUsuario";

    $.ajax({
        method: 'POST',
        url: url,
        data: { usuarioId: usuarioId },
        success: function (data) {

            if (data === true) {
                $("#" + usuarioId).removeClass("purple daken-3").addClass("orange darken-3").text("Reprovado");

                
                M.toast({
                    html: "Usuario Reprovado",
                    classes: "orange darken-3"
                });
            }
            else {
                M.toast({
                    html: "Não foi possível reprovar o usuário"
                });
            }

        }
    })
}