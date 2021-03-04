<template>
  <div class="section">
    <div class="section__title">
      <span class="section__number">{{ formatNumber() }}</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "About",
  props: {
    number: {
      type: Number,
      required: true
    },
    title: {
      type: String,
      required: true
    },
    methods: {
      formatNumber() {
        const fromattedNum = this.number + ".";
        return this.number < 10 ? "0" + fromattedNum : fromattedNum;
      }
    }
  }
};
</script>

<style></style>
