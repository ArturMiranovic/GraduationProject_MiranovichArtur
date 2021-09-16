

$(document).ready(function () {
    $('.icon').hide();

    $('input[name=Login]').keyup(function (e) {
        var self = $(this);
        var currentLogin = self.val();

        var url = '/User/IsUniq?login=' + currentLogin;
        var promise = $.get(url);
        promise.done(function (respone) {
            $('.icon').hide();
            if (respone) {
                $('.icon.ok').show();
                self.css('background', '#58da5570');
            } else {
                $('.icon.cancel').show();
                self.css('background', '#e877777a');
            }
        });
    });

    $('input[name=Password]').keyup(function (e) {
        var self = $(this);
        var currentPassword = self.val();

        var url = '/User/IsUniqPassword?password=' + currentPassword;
        var promise = $.get(url);
        promise.done(function (respone) {
            $('.icon').hide();
            if (respone) {
                $('.icon.ok').show();
                self.css('background', '#58da5570');
            } else {
                $('.icon.cancel').show();
                self.css('background', '#e877777a');
            }
        });
    });

    $('input[name=Name]').keyup(function (e) {
        var self = $(this);
        var currentName = self.val();

        var url = '/User/IsUniqName?name=' + currentName;
        var promise = $.get(url);
        promise.done(function (respone) {
            $('.icon').hide();
            if (respone) {
                $('.icon.ok').show();
                self.css('background', '#58da5570');
            } else {
                $('.icon.cancel').show();
                self.css('background', '#e877777a');
            }
        });
    });


    /*
    function Do(inputName) {
        var self = $(this);
        var currentName = self.val();

        var url = `/User/IsUniq + ${inputName}?${inputName}=` + currentName;
        var promise = $.get(url);
        promise.done(function (respone) {
            $('.icon').hide();
            if (respone) {
                $('.icon.ok').show();
                self.css('background', '#58da5570');
            } else {
                $('.icon.cancel').show();
                self.css('background', '#e877777a');
            }
        });
    }*/


});