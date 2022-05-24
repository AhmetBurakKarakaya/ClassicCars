
var adminHome = new Vue({
    el: "#home",
    data: {
        adminAtt: []
    },
    mounted: function () {
        this.getAdminAtt();
    },
    methods: {
        getAdminAtt: function () {
            var vm = this;
            $.ajax({ url: "/PopularCars/GetPopularCars", method: "POST" })
                .done(function (data) {
                    vm.popularCars = data.data;
                });
        }
    }

})
