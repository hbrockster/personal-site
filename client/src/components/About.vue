<template>
  <Section
    name="About"
    number="01_"
  >
      <template>
        <p>
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
            It has survived not only five centuries, but also the leap into electronic typesetting, remaining 
            essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets 
            containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus 
            PageMaker including versions of Lorem Ipsum.
        </p>
      </template>
  </Section>
</template>s
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import Section from '@/components/Section.vue';

@Component({ components: { Section, }})
export default class About extends Vue {
}
</script>
<style>
</style>
