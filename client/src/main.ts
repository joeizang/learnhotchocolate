import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import Vuetify from "vuetify";
import "material-design-icons-iconfont/dist/material-design-icons.css";
import "vuetify/dist/vuetify.min.css";
import vuetify from "./plugins/vuetify";
import { createProvider } from "./vue-apollo";

Vue.config.productionTip = false;

new Vue({
  router,
  store,
  vuetify,
  apolloProvider: createProvider(),
  render: (h) => h(App),
}).$mount("#app");
