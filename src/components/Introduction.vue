<template>
  <div id="Introduction" class="intro">
    <div class="intro__msg">
      Hello, my name is
    </div>
    <div class="intro__name">Hunter Brock</div>
  </div>
</template>
<script>
export default {
  name: "Introduction"
};
</script>
<style lang="scss">
.intro {
  text-align: left;
  height: 60rem;
}
.intro__msg {
  //color: #a5d1bc;
  color: #cbffe5;
}
.intro__name {
  font-size: 4rem;
  font-weight: 600;
}
</style>
