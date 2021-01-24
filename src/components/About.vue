<template>
  <div class="about" id="about">
    <div class="about-title">
      01.
      <span class="about-title__name">About Me </span>
    </div>
    <div class="about-body"></div>
    <div class="about-picture"></div>
  </div>
</template>

<script>
export default {
  name: "About"
};
</script>

<style lang="scss">
.about {
  height: 50vh;
}
.about-title {
  font-size: 1.5rem;
  font-weight: 500;
  color: #75ebb0;
}
.about-title__name {
  font-size: 2rem;
  font-weight: 600;
}
.about-title_line {
  width: 5rem;
  border: solid red 1px;
}
.about-title__name:after {
  content: "";
  display: block;
  position: relative;
  top: -5px;
  width: 300px;
  height: 8px;
  margin-left: 20px;
  background-color: red;
}
</style>
