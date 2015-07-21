(function($) {
    /**
     * Default module implementation.
     *
     * @author Remo Brunschwiler
     * @namespace Tc.Module
     * @class Default
     * @extends Tc.Module
     */
    Tc.Module.ResponsiveNav = Tc.Module.extend({

        on: function (callback) {
            $('.main-nav').children().clone().appendTo('.responsive-nav');
            $('.responsive-menu-open').on('click', function(event) {
                event.preventDefault();
                $('body').addClass('no-scroll');
                $('.responsive-menu').addClass('open');
            });
            $('.responsive-nav a').on('click', function (event) {
		    
                $('body').removeClass('no-scroll');
                $('.responsive-menu').removeClass('open');
            });
            $('.responsive-menu-close').on('click', function(event) {
                event.preventDefault();
                $('body').removeClass('no-scroll');
                $('.responsive-menu').removeClass('open');
            });
            console.log("done");
            callback();
        }
    });
})(Tc.$);
