(function($) {
    /**
     * Default module implementation.
     *
     * @author Remo Brunschwiler
     * @namespace Tc.Module
     * @class Default
     * @extends Tc.Module
     */
    Tc.Module.ContactSidebar = Tc.Module.extend({

        on: function (callback) {  
            $ctx = this.$ctx;
            console.log("done2");
            $('.slide-out-share').on('click', function (event) {
                event.preventDefault();
                $('.slide-out-popup').fadeToggle(250);
            });

            $('.header-action-button').on('click', function (event) {
                event.preventDefault();
                $('.slide-out-overlay').fadeIn(250);
                $('.slide-out').addClass('open');
            });
            $('.slide-out-close').on('click', function (event) {
                event.preventDefault();
                $('.slide-out-overlay').fadeOut(250);
                $('.slide-out').removeClass('open');
            });
            $('.slide-out-overlay').on('click', function (event) {
                event.preventDefault();
                $('.slide-out-overlay').fadeOut(250);
                $('.slide-out').removeClass('open');
            });
            callback();
        }
    });
})(Tc.$);
