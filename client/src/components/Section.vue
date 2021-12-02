<template>
  <div :id="name.toLowerCase()" class="section">
    <div v-if="name" class="section__name">
      <span>{{ number }}</span>
      {{ name }}
      </div>
    <div v-if="title" class="section__title">{{ title }}</div>
    <slot></slot>
  </div>
</template>s
<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component({ })
export default class Introduction extends Vue {
  @Prop({required: true}) name!: string;
  @Prop({required: true}) title!: string;
  @Prop({required: true}) number!: string;
}
</script>
<style>
.section {
  text-align: left;
  margin: 15% 10%;
}
.section p {
  margin-bottom: 2rem;
  max-width: 60%;
  line-height: 1.5rem
}
.section__name {
  font-size: 4rem;
  font-weight: 600;
  color: #64ebd4;
}
.section__name span {
  font-size: 4rem;
  font-weight: 400;
  font-family: 'Roboto Mono';
  color: #3c7c5c;
  letter-spacing: -5px;
}
.section__title {
  font-size: 4rem;
  font-weight: 600;
}
</style>
