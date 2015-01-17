(function ($) {
    var app = $.sammy(function () {
        this.get('#/', function () {
            loadInsideContent('Views/Index');
        });
        this.get('#/dev', function () {
            loadInsideContent('Views/DevPage');
        });
        this.get('#/pht', function () {
            loadInsideContent('Views/PhtPage');
        });
        this.get('#/Content/:var', function () {
            var param = this.params['var'];
            this.redirect('', param);
        });
    });
    $(function () {
        app.run('#/');
    });
})(jQuery);

function loadInsideContent(url) {
    $.ajax({
        url: url,
        cache: false,
        type: "POST",
        success: function (msg) {
            $("#content").html(msg);
        }
    });
}