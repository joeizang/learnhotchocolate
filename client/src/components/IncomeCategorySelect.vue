<template>
  <v-col cols="12" sm="6">
    <v-select :items="incomeCategories" item-text="incomeCategoryName" label="Income Category*" required> </v-select>
  </v-col>
</template>

<script lang="ts">
import Vue from "vue";
import gql from "graphql-tag";

export default Vue.extend({
  apollo: {
    incomeCategories: gql`
      query getCategories {
        incomeCategories {
          id
          incomeCategoryName
        }
      }
    `,
  },
  data: function() {
    return {
      cats: [],
    };
  },
});
</script>

<style scoped></style>
