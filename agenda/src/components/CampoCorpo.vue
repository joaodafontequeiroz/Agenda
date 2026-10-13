<script>
  export default{
    data(){
      return{

      }
    },

    props: {
      corpo: String
    },

    emits: ["update:corpo"],
  }
</script>

<template>

<textarea :value="corpo" class="corpo" placeholder="Digite aqui" @input="$emit('update:corpo', $event.target.value)"></textarea>

</template>


<style scoped>

.corpo{
  width: 100%;
  min-height: 60vh;
  box-sizing: border-box;
  padding: 12px 0;
  font-size: 1rem;
  line-height: 1.7;
  color: #1f2d1f;
  font-family: inherit;
  background: transparent;
  border: none;
  resize: vertical;
}

.corpo:focus {
  outline: none;
}

.corpo::placeholder {
  color: #a9b8a5;
}

</style>
