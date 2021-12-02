<template>
  <Section
    name="Skills"
    number="02_"
  >
      <template>
        <div class="skills-list">
          <Skill
            title="VueJs"
            description="Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            experience="2"
            imageUrl="vue.png"
            />
            <Skill
            title="VueJs"
            description="Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            experience="2"
            imageUrl="vue.png"
            />
            <Skill
            title="VueJs"
            description="Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            experience="2"
            imageUrl="vue.png"
            />
            <Skill
            title="VueJs"
            description="Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            experience="2"
            imageUrl="vue.png"
            />
            <Skill
            title="VueJs"
            description="Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            experience="2"
            imageUrl="vue.png"
            />
          <!-- <ul>
              <li>VueJs</li>
              <li>Javascript</li>
              <li>TypeScript</li>
              <li>C#</li>
              <li>Java</li>
              <li>C</li>
              <li>C++</li>
          </ul>
          <ul>
              <li>SQL</li>
              <li>Python</li>
              <li>HTML</li>
              <li>CSS</li>
              <li>Kotlin</li>
              <li>Docker</li>
              <li>NodeJs</li>
          </ul>
          <ul>
              <li>Git</li>
              <li>GitLab</li>
              <li>GitHub</li>
              <li>.NET</li>
              <li>ASP.NET</li>
              <li>Maven</li>
              <li>Qt</li>
          </ul>
          <ul>
              <li>Kubernetes</li>
              <li>Virtual Machines</li>
              <li>Linux</li>
              <li>Shell/Bash</li>
              <li>PowerShell</li>
              <li>JavaFx</li>
              <li>Entity Framework</li>
          </ul> -->
        </div>
      </template>
  </Section>
</template>
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import Section from '@/components/Section.vue';
import Skill from '@/components/Skill.vue';

@Component({ components: { Section, Skill}})
export default class Skills extends Vue {
}
</script>
<style>
.skills-list {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
}
li {
    padding: 1.5rem 1.5rem 1.5rem 0.5rem;
    font-size: 1.25rem;
}
ul { 
  /* padding: 0 5rem; */
}
</style>
