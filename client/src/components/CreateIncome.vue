<template>
  <v-dialog max-width="600px">
    <template #activator="{ on: dialog }">
      <v-tooltip right>
        <template #activator="{ on: tooltip }">
          <v-btn dark fab class="primary mt-5" v-on="{ ...tooltip, ...dialog }"><v-icon>mdi-plus</v-icon></v-btn>
        </template>
        <span>Create Income</span>
      </v-tooltip>
    </template>
    <v-card>
      <v-card-title>
        <span class="headline">Create Income</span>
      </v-card-title>
      <v-card-text>
        <v-container>
          <v-row>
            <v-menu>
              <v-col cols="12">
                <v-text-field
                  :value="incomeDate"
                  slot="activator"
                  type="date"
                  label="Date*"
                  prepend-icon="mdi-calendar"
                  required
                ></v-text-field>
                <v-date-picker v-model="incomeDate"> </v-date-picker>
              </v-col>
            </v-menu>

            <v-col cols="12">
              <v-text-field label="Amount*" type="number" required></v-text-field>
            </v-col>
            <v-col cols="12">
              <v-text-field label="Description" type="text" required></v-text-field>
            </v-col>
            <IncomeCategorySelect />
            <v-col cols="12" sm="6">
              <v-autocomplete
                :items="[
                  'Skiing',
                  'Ice hockey',
                  'Soccer',
                  'Basketball',
                  'Hockey',
                  'Reading',
                  'Writing',
                  'Coding',
                  'Basejump',
                ]"
                label="Income Source*"
                multiple
              ></v-autocomplete>
            </v-col>
          </v-row>
        </v-container>
        <small>*indicates required field</small>
      </v-card-text>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn color="blue darken-1" text @click="dialog = false">Close</v-btn>
        <v-btn color="blue darken-1" text @click="dialog = false">Save</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script lang="ts">
import Vue from "vue";
import IncomeCategorySelect from "./IncomeCategorySelect.vue";

export default Vue.extend({
  components: {
    IncomeCategorySelect,
  },
  data: () => ({
    dialog: false,
    incomeDate: null,
  }),
});
</script>

<style scoped></style>

v
