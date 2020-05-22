<template>
  <v-app>
    <v-app-bar app color="primary" dark>
      <div class="d-flex align-center">
        <v-img
          alt="Vuetify Logo"
          class="shrink mr-2"
          contain
          src="https://cdn.vuetifyjs.com/images/logos/vuetify-logo-dark.png"
          transition="scale-transition"
          width="40"
        />

        <v-img
          alt="Vuetify Name"
          class="shrink mt-1 hidden-sm-and-down"
          contain
          min-width="100"
          src="https://cdn.vuetifyjs.com/images/logos/vuetify-name-dark.png"
          width="100"
        />
      </div>

      <v-spacer></v-spacer>

      <v-btn href="https://github.com/vuetifyjs/vuetify/releases/latest" target="_blank" text>
        <span class="mr-2">Latest Release</span>
        <v-icon>mdi-open-in-new</v-icon>
      </v-btn>
    </v-app-bar>

    <v-content>
      <v-card width="400" class="mx-auto mt-12 p10">
        <v-card-title>
          <h2 class="display-1">Welcome, Sign in</h2>
        </v-card-title>
        <v-card-text>
          <v-form>
            <v-text-field label="Username" prepend-icon="mdi-account-circle" />
            <v-text-field label="Password" type="password" prepend-icon="mdi-lock" append-icon="mdi-eye-off" />
          </v-form>
        </v-card-text>
        <v-spacer></v-spacer>
        <v-card-actions>
          <v-btn dark large color="success">Register</v-btn>
          <v-spacer></v-spacer>
          <v-btn dark large color="info">Login</v-btn>
        </v-card-actions>
        <v-spacer></v-spacer>
      </v-card>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
//import HelloWorld from "./components/HelloWorld.vue";

export default Vue.extend({
  name: "App",

  components: {
    //HelloWorld
  },

  data: () => ({
    //
  })
});
</script>
