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
      <CreateIncome></CreateIncome>
      <v-card width="300" class="mx-auto mt-12 p10" v-for="income in incomes" :key="income.id">
        <v-card-title>
          <h4 class="headline">Payer: {{ income.incomeSource.name }}</h4>
        </v-card-title>
        <v-card-text>
          <span class="body-1"
            ><v-icon light left>mdi-currency-ngn</v-icon>{{ new Intl.NumberFormat().format(income.amount) }}</span
          >
          <v-spacer></v-spacer>
          <span>{{ new Date(Date.parse(income.incomeDate)) }}</span>
        </v-card-text>
        <v-spacer></v-spacer>
        <v-card-actions>
          <v-btn light large color="success">Print</v-btn>
          <v-spacer></v-spacer>
        </v-card-actions>
        <v-spacer></v-spacer>
      </v-card>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import gql from "graphql-tag";
import CreateIncome from "@/components/CreateIncome.vue";

export default Vue.extend({
  name: "App",
  apollo: {
    incomes: gql`
      query getAllIncome {
        incomes {
          id
          amount
          incomeDate
          incomeSource {
            name
          }
        }
      }
    `,
  },
  components: { CreateIncome },

  data: () => ({
    //
  }),
  computed: {},
});
</script>
