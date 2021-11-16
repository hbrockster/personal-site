<template>
  <Section
    name="Skills"
    number="02_"
  >
      <template>
        <ul>
            <li>C#</li>
            <li>C#</li>
            <li>C#</li>
            <li>C#</li>
            <li>C#</li>
            <li>C#</li>
            <li>C#</li>
        </ul>
      </template>
  </Section>
</template>
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import Section from '@/components/Section.vue';

@Component({ components: { Section, }})
export default class Skills extends Vue {
}
</script>
<style>
li {
    padding: 0.5rem;
}
</style>
